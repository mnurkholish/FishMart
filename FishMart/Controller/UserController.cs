using FishMart.Services;

namespace FishMart.Controller
{
    public class UserController
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }
        public bool createUser(string email, string password, string username, string noTelp)
        {
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(noTelp))
            {
                MessageBox.Show("Data tidak boleh kosong, isi semua kolom yang ada", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var user = _userService.Create(email, password, username, noTelp);
            return user;
        }

        public bool UpdateUser(int id, string username, string noTelp, string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(noTelp))
            {
                MessageBox.Show("Username dan No Telepon tidak boleh kosong!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var user = _userService.UpdateUser(id, username, noTelp, password);
            return user;
        }
        public void FillDataWithAkunKasir(DataGridView dataGrid)
        {
            _userService.FillWithAkunKasir(dataGrid);
        }

        public void ToggleUserStatus(int userId)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin mengubah status kasir ini?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _userService.ToggleUserStatus(userId);
                MessageBox.Show("Status berhasil diubah", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
