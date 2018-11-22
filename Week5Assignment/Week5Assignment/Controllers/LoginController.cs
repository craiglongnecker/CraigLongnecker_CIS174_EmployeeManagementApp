using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;
using Week5Assignment.Models;

namespace Week5Assignment.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(Week5Assignment.Models.User userModel)
        {
            using (Week5AssignmentEntities db = new Week5AssignmentEntities())
            {
                var encryptedPassword = EncryptString(userModel.Password);
                var userDetails = db.Users.Where(x => x.UserName == userModel.UserName && x.Password == encryptedPassword).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = "Invalid User Name or Password.";
                    return View("Login", userModel);
                }
                else
                {
                    Session["userID"] = userDetails.UserID;
                    Session["userName"] = userDetails.UserName;
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public string EncryptString(string encryptString)
        {
            string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        NewMethod(encryptString, cs);
                        cs.Close();
                    }
                    encryptString = System.Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        private static void NewMethod(string encryptString, CryptoStream cs)
        {
            cs.Write(buffer: Encoding.Unicode.GetBytes(encryptString), offset: 0, count: Encoding.Unicode.GetBytes(encryptString).Length);
        }

        public ActionResult LogOut()
        {
            int userId = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}