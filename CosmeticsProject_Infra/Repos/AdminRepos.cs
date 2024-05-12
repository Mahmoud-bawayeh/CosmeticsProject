using CosmeticsOnlineStore_Core.DTO.OrderRecordDTO;
using CosmeticsOnlineStore_Core.DTO.productsDTO;
using CosmeticsOnlineStore_Core.DTO.UserDTO;
using CosmeticsProject_Core.Context;
using CosmeticsProject_Core.Entity;
using CosmeticsProject_Core.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsProject_Infra.Repos
{
    public class AdminRepos : IAdminReposInterface
    {
        private CosmeticsOnlineStoreDBContext _dbContext;
        public AdminRepos(CosmeticsOnlineStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateProduct(CreateProductDTO product)
        {
            var C = new Product();
            C.ProductName = product.ProductName;
            C.AvailableQuantity = product.AvailableQuantity;
            C.Image = product.Image;
            C.Price = product.Price;
            C.ProductDescription = product.ProductDescription;
            await _dbContext.Product.AddAsync(C);
            await _dbContext.SaveChangesAsync();

        }

        public async Task<object> DeleteProduct(int Id)
        {

            var product = await _dbContext.Product.FindAsync(Id);
            if (product != null)
            {
                _dbContext.Product.Remove(product);
                await _dbContext.SaveChangesAsync();
                return "Users Removed Successfully";
            }
            
            
                throw new ArgumentException("Product not found.");
            

        }

        public async Task<object> DeleteUser(int Id)
        {
            var user = await _dbContext.Users.FindAsync(Id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                await _dbContext.SaveChangesAsync();
                return "Users Removed Successfully";
            }


            throw new ArgumentException("Product not found.");

        }

        public async Task<List<OrderRecordDTO>> GetAllOrder()
        {
            var or = new List<OrderRecordDTO>();
            var Order = await _dbContext.Order.ToListAsync();
            if (Order != null)
            {
                foreach (var order in Order)
                {
                    var O = new OrderRecordDTO();
                    O.TotalPrice = order.TotalPrice;
                    O.CustomerID = order.CustomerID;
                    O.DiscountAmount = order.DiscountAmount;
                    O.TaxAmount = order.TaxAmount;
                    O.OrderId = order.Id;

                    or.Add(O);
                }
                return or.ToList();

            }
            else { throw new NotImplementedException("Order Not Found"); }
        }

        public async Task<List<UserRecordDTO>> GetAllUsers()
        {
            var result = new List<UserRecordDTO>();
            var Users = await _dbContext.Users.ToListAsync();
            if (Users != null)
            {
                foreach (var user in Users)
                {
                    var dto = new UserRecordDTO();
                    dto.FirstName = user.FirstName;
                    dto.LastName = user.LastName;
                    dto.Email = user.Email;
                    dto.Phone = user.Phone;
                    dto.Birthday = user.Birthday;
                    dto.Id = user.Id;
                    dto.Image = user.Image;
                    dto.UserType = user.UserType;
                    result.Add(dto);

                }
                return result.ToList();


            }
            else
            {
                throw new NotImplementedException("User Not Found ");
            }
     

        }

        public async Task<object> GetOrderById(int Id)
        {
            var result = _dbContext.Order.Find(Id);
            return result;


        }

        public async Task<productDetalsDto> GetproductById(int Id)
        {
            var producte = await _dbContext.Product.FindAsync(Id);

            if (producte != null)
            {
                
                await _dbContext.SaveChangesAsync();

                throw new ArgumentException("Successfully Deleted");
            }
            else
            {
                throw new ArgumentException("Producte not found");
            }
        }

        public async Task<productDetalsDto> GetproductDetalsById(int Id)
        {
            var product= await _dbContext.Product.FindAsync(Id);

            if (product != null)
            {
               
                await _dbContext.SaveChangesAsync();

                throw new ArgumentException("Successfully Deleted");
            }
            else
            {
                throw new ArgumentException("Producte not found");
            }

        }

        public async Task<UserRecordDTO> GeUserById(int Id)
        {
            var user = await _dbContext.Users.FindAsync(Id);

            if (user != null)
            {
                
                await _dbContext.SaveChangesAsync();

                throw new ArgumentException("Successfully Deleted");
            }
            else
            {
                throw new ArgumentException("Producte not found");
            }
        }

        public async Task UpdateProduct(UpdateProductDTO dto)
        {
            var product = await _dbContext.Product.FindAsync(dto.Id);

            if (product != null)
            {
                product.Id = dto.Id;
                product.Price = dto.Price;
                product.ProductName = dto.ProductName;
                product.ProductDescription = dto.ProductDescription;
                product.AvailableQuantity = dto.AvailableQuantity;
                product.Image = dto.Image;

               

                await _dbContext.SaveChangesAsync();
                throw new ArgumentException("successfully Updated");
            }
            else
            {
                throw new ArgumentException("Product not found");
            }
        }

        Task<object> IAdminReposInterface.GeUserById(int Id)
        {
            
        }
    }

}
