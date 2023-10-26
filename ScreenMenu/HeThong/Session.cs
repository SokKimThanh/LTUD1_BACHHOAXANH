using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LTUD1_MF_BHX.ScreenMenu.HeThong
{

    public class Session
    {
        private static string username = "";// chưa nhớ password username
        public string Username { get => username; set => username = value; }

        //public string Password { get; set; }
        //private static bool rememberMe = false;// chưa nhớ password username

        private Dictionary<string, object> _lst = new Dictionary<string, object>();

        //public bool RememberMe { get => rememberMe; set => rememberMe = value; }

        /// <summary>
        /// tạo mới và chỉnh sửa value 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void Add(string key, object value)
        {
            if (_lst.ContainsKey(key))//chỗ này là kiểm tra xem có key đó chưa nếu 
                _lst[key] = value;
            else
                _lst.Add(key, value);//còn không có thì mình add vào;
        }
        /// <summary>
        /// lấy session theo key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private object Get(string key)
        {
            if (_lst.ContainsKey(key))
                return _lst[key];
            else
                return "";
        }

        public object this[string key]
        {
            set { Add(key, value); }
            get { return Get(key); }
        }
        /// <summary>
        /// xóa dữ liệu trong list (xóa session)
        /// </summary>
        public void Clear()
        {
            _lst.Clear();
        }

        /// <summary>
        /// Lưu mật khẩu user name cho lần đăng nhập sau
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        //public void RememberMeLogin(bool RememberMeCheck)
        //{
        //if (RememberMeCheck == true)
        //    {
        //        // Ghi thông tin vào tệp  
        //        //using (var writer = new StreamWriter("login.txt"))
        //        //{//mo file
        //        //    writer.WriteLine($"{Username}#{Password}");
        //        //}//dong file 
        //        this["username"] = Username;//lưu session
        //    }
        //    else
        //    {
        //        this["username"] = ""; ;//xóa session
        //    }
        //else
        //{
        //    // Đọc thông tin từ tệp 
        //    using (var reader = new StreamReader("login.txt"))
        //    {//mo file
        //        var fileContents = reader.ReadToEnd();
        //        string[] arr = fileContents.ToString().Split("#");
        //        Username = arr[0];
        //        Password = arr[1];
        //    }//dong file
        //    // hoặc lấy key
        //    Get(Username);
        //    RememberMe = false;
        //}
        //}
    }

}
