using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NqdLesson08.Models;

namespace NqdLesson08.Controllers
{


    public class NqdAccountController : Controller
    {
        private static List<NqdAccount> NqdListAccount = new List<NqdAccount>()
        {
            new NqdAccount
                {
                    NqdId = 230022113,
                    NqdFullName = "Nguyễn Quốc Duy",
                    NqdEmail = "yudnguyen2005@gmail.com",
                    NqdPhone = "0981652921",
                    NqdAddress = "Lớp K23CNT2",
                    NqdAvatar = "duynguyen.jpg",
                    NqdBirthday = new DateTime(2005, 02, 18),
                    NqdGender = "Nam",
                    NqdPassword = "18022005",
                    NqdFacebook = "https://www.facebook.com/NguyenQuocDuy1802"
                },
                new NqdAccount
                {
                    NqdId = 2,
                    NqdFullName = "Trần Thị B",
                    NqdEmail = "tranthib@example.com",
                    NqdPhone = "0987654321",
                    NqdAddress = "456 Đường B, Quận 3, TP.HCM",
                    NqdAvatar = "avatar2.jpg",
                    NqdBirthday = new DateTime(1992, 8, 15),
                    NqdGender = "Nữ",
                    NqdPassword = "password2",
                    NqdFacebook = "https://facebook.com/tranthib"
                },
                new NqdAccount
                {
                    NqdId = 3,
                    NqdFullName = "Lê Văn C",
                    NqdEmail = "levanc@example.com",
                    NqdPhone = "0911222333",
                    NqdAddress = "789 Đường C, Quận 5, TP.HCM",
                    NqdAvatar = "avatar3.jpg",
                    NqdBirthday = new DateTime(1988, 12, 1),
                    NqdGender = "Nam",
                    NqdPassword = "password3",
                    NqdFacebook = "https://facebook.com/levanc"
                },
                new NqdAccount
                {
                    NqdId = 4,
                    NqdFullName = "Phạm Thị D",
                    NqdEmail = "phamthid@example.com",
                    NqdPhone = "0909876543",
                    NqdAddress = "321 Đường D, Quận 7, TP.HCM",
                    NqdAvatar = "avatar4.jpg",
                    NqdBirthday = new DateTime(1995, 3, 10),
                    NqdGender = "Nữ",
                    NqdPassword = "password4",
                    NqdFacebook = "https://facebook.com/phamthid"
                },
                new NqdAccount
                {
                    NqdId = 5,
                    NqdFullName = "Hoàng Văn E",
                    NqdEmail = "hoangvane@example.com",
                    NqdPhone = "0933444555",
                    NqdAddress = "654 Đường E, Quận 10, TP.HCM",
                    NqdAvatar = "avatar5.jpg",
                    NqdBirthday = new DateTime(1991, 7, 22),
                    NqdGender = "Nam",
                    NqdPassword = "password5",
                    NqdFacebook = "https://facebook.com/hoangvane"
                }
        };
        // GET: NqdAccountController
        public ActionResult NqdIndex()
        {
            return View(NqdListAccount);
        }

        // GET: NqdAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NqdAccountController/Create
        public ActionResult NqdCreate()
        {
            var NqdModel = new NqdAccount();
            return View(NqdModel);
        }

        // POST: NqdAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NqdCreate(NqdAccount NqdModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Giả sử bạn có DbContext tên _context đã được Inject trong Controller
                    //_context.NqdAccounts.Add(NqdModel);
                    //_context.SaveChanges();
                    NqdListAccount.Add(NqdModel);
                    return RedirectToAction(nameof(NqdIndex));
                }

                // Nếu dữ liệu không hợp lệ, trả về View để người dùng sửa
                return View(NqdModel);
            }
            catch (Exception ex)
            {
                // Bạn có thể log lỗi ở đây nếu cần
                ModelState.AddModelError("", "Có lỗi xảy ra khi thêm mới: " + ex.Message);
                return View(NqdModel);
            }
        }

        // GET: NqdAccountController/Edit/5
        public ActionResult NqdEdit(int id)
        {
            var account = NqdListAccount.FirstOrDefault(a => a.NqdId == id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }


        // POST: NqdAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NqdEdit(int id, NqdAccount updatedAccount)
        {
            try
            {
                var existingAccount = NqdListAccount.FirstOrDefault(a => a.NqdId == id);
                if (existingAccount == null)
                {
                    return NotFound();
                }

                // Cập nhật thông tin
                existingAccount.NqdFullName = updatedAccount.NqdFullName;
                existingAccount.NqdEmail = updatedAccount.NqdEmail;
                existingAccount.NqdPhone = updatedAccount.NqdPhone;
                existingAccount.NqdAddress = updatedAccount.NqdAddress;
                existingAccount.NqdAvatar = updatedAccount.NqdAvatar;
                existingAccount.NqdBirthday = updatedAccount.NqdBirthday;
                existingAccount.NqdGender = updatedAccount.NqdGender;
                existingAccount.NqdPassword = updatedAccount.NqdPassword;
                existingAccount.NqdFacebook = updatedAccount.NqdFacebook;

                return RedirectToAction(nameof(NqdIndex));
            }
            catch
            {
                return View(updatedAccount);
            }
        }


        // GET: NqdAccountController/Delete/5
        public ActionResult NqdDelete(int id)
        {
            var account = NqdListAccount.FirstOrDefault(a => a.NqdId == id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }


        // POST: NqdAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NqdDelete(int id, IFormCollection collection)
        {
            try
            {
                var account = NqdListAccount.FirstOrDefault(a => a.NqdId == id);
                if (account != null)
                {
                    NqdListAccount.Remove(account);
                }

                return RedirectToAction(nameof(NqdIndex));
            }
            catch
            {
                return View();
            }
        }

    }
}