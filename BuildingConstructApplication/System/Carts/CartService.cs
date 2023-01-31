using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.EntityFrameworkCore;
using ViewModels.Carts;
using ViewModels.Pagination;
using ViewModels.Response;
using System.Linq.Dynamic.Core;
using System.Text;
using Gridify;

namespace Application.System.Carts
{
    public class CartService : ICartService
    {
        private readonly BuildingConstructDbContext _context;

        public CartService(BuildingConstructDbContext context)
        {
            _context = context;
        }

        public async Task<BaseResponse<CartDTO>> Create(Guid userID, CreateCartRequest requests)
        {
            BaseResponse<CartDTO>? response=null;

            var existed = await _context.Carts.Where(x => x.UserID.Equals(userID) && x.ProductID == requests.ProductID).FirstOrDefaultAsync();

            if (existed != null)
            {
                var quantity = existed.Quantity;
                quantity += requests.Quantity;

                existed.Quantity = quantity;

                _context.Carts.Update(existed);
                await _context.SaveChangesAsync();

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                };
                return response;

            }

            var cart = new Cart()
            {
                ProductID = requests.ProductID,
                Quantity = requests.Quantity,
                UserID = userID
            };
            await _context.Carts.AddAsync(cart);
            var rs = await _context.SaveChangesAsync();

            if (rs > 0)
            {
                var result = await _context.Carts
               .Include(x => x.Products)
                   .ThenInclude(x => x.MaterialStore)
                       .ThenInclude(x => x.User)
               .Where(x => x.UserID.Equals(userID) && x.ProductID == requests.ProductID).FirstOrDefaultAsync();

                if (result != null)
                {
                    response = new()
                    {
                        Code = BaseCode.SUCCESS,
                        Message = BaseCode.SUCCESS_MESSAGE,
                        Data = MapToDTO(result)
                    };
                    return response;
                }
            }
            else
            {
                response = new()
                {
                    Code = BaseCode.ERROR,
                    Message = BaseCode.ERROR_MESSAGE,
                };
            }
            return response;

        }

        public async Task<BasePagination<List<CartDTO>>> GetAll(Guid UserID, PaginationFilter filter)
        {
            BasePagination<List<CartDTO>> response;

            var orderBy = filter._orderBy.ToString();
            int totalRecord;
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };
            List<CartDTO> ls = new();


            var cart = await _context.Carts
                .Include(x => x.Products)
                    .ThenInclude(x => x.MaterialStore)
                        .ThenInclude(x => x.User)
                .Where(x => x.UserID.Equals(UserID))
                .OrderBy(filter._sortBy + " " + orderBy)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .ToListAsync();

            totalRecord = await _context.Carts.Where(x => x.UserID.Equals(UserID)).CountAsync();


            if (!cart.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Data = new(),
                    Message = BaseCode.NOTFOUND_MESSAGE
                };
                return response;
            }

            foreach (var item in cart)
            {
                ls.Add(MapToDTO(item));
            }

            double totalPages;

            totalPages = ((double)totalRecord / (double)filter.PageSize);

            var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            Pagination pagination = new()
            {
                CurrentPage = filter.PageNumber,
                PageSize = filter.PageSize,
                TotalPages = roundedTotalPages,
                TotalRecords = totalRecord
            };

            response = new()
            {
                Code = BaseCode.SUCCESS,
                Message = BaseCode.SUCCESS_MESSAGE,
                Data = ls,
                Pagination = pagination
            };

            return response;

        }

        public async Task<BaseResponse<string>> Remove(Guid userID, List<RemoveCartRequest> requests)
        {
            BaseResponse<string> response;


            if (requests.Count == 0)
            {
                var existed = await _context.Carts.Where(x => x.UserID.Equals(userID)).ToListAsync();
                if (existed.Any())
                {
                    _context.RemoveRange(existed);
                    await _context.SaveChangesAsync();

                    response = new()
                    {
                        Code = BaseCode.SUCCESS,
                        Message = BaseCode.SUCCESS_MESSAGE
                    };
                    return response;


                }
                else
                {
                    response = new()
                    {
                        Code = BaseCode.ERROR,
                        Message = "THERE NOT THING TO REMOVE"
                    };
                    return response;
                }
            }
            else
            {
                foreach (var item in requests)
                {
                    var remove = _context.Carts.Where(x => x.UserID.Equals(userID) && x.ProductID == item.ProductID).FirstOrDefault();
                    if (remove != null)
                    {
                        _context.Carts.Remove(remove);
                        await _context.SaveChangesAsync();
                    }
                }
            }

            response = new()
            {
                Code = BaseCode.SUCCESS,
                Message = BaseCode.SUCCESS_MESSAGE
            };
            return response;



        }

        public async Task<BaseResponse<string>> Update(Guid userID, List<CreateCartRequest> requests)
        {
            BaseResponse<string> response;
            int rs = 0;

            IQueryable<Cart> query = _context.Carts.Where(x => x.UserID.Equals(userID));
            StringBuilder existed = new();

            var count = requests.Count;
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    existed.Append("ProductID=" + requests[i].ProductID);
                    break;
                }
                existed.Append("ProductID=" + requests[i].ProductID + "|");
            }
            query = query.ApplyFiltering(existed.ToString());

            if (existed != null)
            {
                _context.RemoveRange(query);
                await _context.SaveChangesAsync();
            }

            foreach (var item in requests)
            {
                var cart = new Cart()
                {
                    ProductID = item.ProductID,
                    Quantity = item.Quantity,
                    UserID = userID
                };
                await _context.Carts.AddAsync(cart);
                rs = await _context.SaveChangesAsync();


            }

            if (rs > 0)
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                };

            }
            else
            {
                response = new()
                {
                    Code = BaseCode.ERROR,
                    Message = BaseCode.ERROR_MESSAGE,
                };
            }
            return response;

        }

        private CartDTO MapToDTO(Cart cart)
        {
            CartDTO dto = new()
            {
                Image = cart.Products.Image,
                LastModifiedAt = cart.LastModifiedAt,
                MaterialStoreID = cart.Products.MaterialStoreID,
                MaterialStoreName = cart.Products.MaterialStore.User.LastName + " " + cart.Products.MaterialStore.User.FirstName,
                ProductID = cart.ProductID,
                ProductName = cart.Products.Name,
                Quantity = cart.Quantity,
                UnitInStock = cart.Products.UnitInStock,
                UnitPrice = cart.Products.UnitPrice,
            };
            return dto;
        }
    }
}
