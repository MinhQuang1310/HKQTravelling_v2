using HKQTravelling.Data;
using HKQTravelling.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
/*using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;*/
using System.Security.Cryptography;
using System.Text;

namespace HKQTravelling.Controllers
{
    public class AccountController : Controller
    {

        private readonly ApplicationDBContext data;

        public AccountController(ApplicationDBContext data)
        {
            this.data = data;
        }
        #region aync
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(IFormCollection formCollection)
        {
            string username = formCollection["UserName"];
            string password = formCollection["Password"];
            string hashedPassword = GetMD5Hash(password);
            var dbUser = await data.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == hashedPassword);
            if (dbUser != null)
            {
                if (dbUser.RoleId == 1)
                {
                    // Chuyển đổi đối tượng dbUser thành chuỗi JSON
                    var userJson = JsonConvert.SerializeObject(dbUser);

                    // Lưu chuỗi JSON vào phiên
                    HttpContext.Session.SetString("use", userJson);

                    // Lưu phiên lại
                    await HttpContext.Session.CommitAsync();
                    return RedirectToAction("Index", "AdminHome", new { area = "Admin" });
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(IFormCollection formCollection)
        {
            string username = formCollection["UserName"].ToString();
            string password = formCollection["Password"].ToString();
            string email = formCollection["Email"].ToString();
            string phone_number = formCollection["PhoneNumber"].ToString();
            string fullname = formCollection["FullName"].ToString();
            string gender = formCollection["Gender"].ToString();
            string birthdate = formCollection["BirthDate"].ToString();
            if (checkUsername(username))
            {
                ViewData["existed_user"] = "Tài khoản này đã tồn tại!";
                return View();
            }
            else if (checkEmail(email))
            {
                ViewData["existed_email"] = "Email này đã tồn tại";
                return View();
            }
            else
            {
                var dbUser = new Models.User
                {
                    Username = username,
                    Password = GetMD5Hash(password),
                    Status = 1,
                    CreationDate = DateTime.Now,
                    RoleId = 1
                };

                var dbUserDetails = new Models.UserDetails
                {

                    Email = email,
                    PhoneNumber = phone_number,
                    FullName = fullname,
                    Gender = checkGender(gender),
                    Birthdate = Convert.ToDateTime(birthdate),
                    User = dbUser
                };
                data.Users.Add(dbUser);
                data.UserDetails.Add(dbUserDetails);
/*                await data.SaveChangesAsync();*/
                return RedirectToAction("Login", "Account");
            }
        }

        #endregion

        #region functions
        // Hàm mã hóa MD5
        private string GetMD5Hash(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                // Nếu input rỗng hoặc null, trả về chuỗi rỗng.
                return string.Empty;
            }
            using (var md5 = MD5.Create())
            {
                var dulieu = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                var builder = new StringBuilder();

                for (int i = 0; i < dulieu.Length; i++)
                {
                    builder.Append(dulieu[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private bool checkUsername(string username)
        {
            return data.Users.Count(u => u.Username == username) > 0;
        }
        private bool checkEmail(string email)
        {
            return data.UserDetails.Count(u => u.Email == email) > 0;
        }

        private string checkGender(string gender)
        {
            if (string.Equals(gender, "Nam", StringComparison.OrdinalIgnoreCase))
            {
                return "Male";
            }
            else if (string.Equals(gender, "Nữ", StringComparison.OrdinalIgnoreCase))
            {
                return "Female";
            }
            else
            {
                // Trường hợp không xác định, bạn có thể xử lý một cách phù hợp.
                return "Other"; // Hoặc bạn có thể sử dụng giá trị mặc định khác.
            }
        }
        #endregion
    }
}
