

using System.Data.SqlClient;

namespace ADOImp
{

    public partial class Form1 : Form
    {
        private string _connectionString = @"Data Source=[::1], 1401;Initial Catalog=VisualProgramming;User ID=sa;Password=@Khadijah^21#";
        private SqlConnection _connection;

        public Form1()
        {
            InitializeComponent();

            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            DisplayData();
        }

        ~Form1()
        {
            _connection.Close();
            
        }

        private List<Game> GetDatas()
        {
            var games = new List<Game>();
            var cmd = _connection.CreateCommand();

            cmd.CommandText = $"SELECT * FROM games";

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var game = new Game();
                    game.Id = reader["id"].ToString();
                    game.Name = reader["name"].ToString();
                    game.Platform = reader["platform"].ToString();
                    game.Genre = reader["genre"].ToString();

                    games.Add(game);
                }
            }

            return games;
        }

        private Game GetData(string id)
        {
            var game = new Game();
            var cmd = _connection.CreateCommand();

            cmd.CommandText = $"SELECT * FROM games WHERE id like '{id}%'";

            using(var reader = cmd.ExecuteReader())
            {
                reader.Read();
                try
                {
                    game.Id = reader["id"].ToString();
                    game.Name = reader["name"].ToString();
                    game.Platform = reader["platform"].ToString();
                    game.Genre = reader["genre"].ToString();
                }
                catch
                {
                    game = new Game();
                    // TODO: handle exception
                }
            }

            return game;
        }

        private void InsertData(string name,string genre, string platform)
        {
            var cmd = _connection.CreateCommand();

            cmd.CommandText = $"INSERT INTO games VALUES('{Guid.NewGuid()}','{name}','{genre}','{platform}')";
            cmd.ExecuteNonQuery();
        }

        private void UpdateData(string id,string name,string genre,string platform)
        {
            var cmd = _connection.CreateCommand();
            cmd.CommandText = $"UPDATE games set name='{name}', genre='{genre}', platform='{platform}' where id='{id}'";
            cmd.ExecuteNonQuery();
        }

        private void DeleteData(string id)
        {
            var cmd = _connection.CreateCommand();

            cmd.CommandText = $"DELETE FROM games WHERE id='{id}'";
            cmd.ExecuteNonQuery();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var genre = genreTextBox.Text;
            var platform = platformTextBox.Text;

            InsertData(name, genre, platform);
            DisplayData();
        }

        private void IdTextBoxOnTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text) || idTextBox.Text.Length < 3) return;

            var data = GetData(idTextBox.Text);

            idTextBox.Text = string.IsNullOrEmpty(data.Id) ? string.Empty : data.Id;
            nameTextBox.Text = string.IsNullOrEmpty(data.Name) ? string.Empty : data.Name;
            platformTextBox.Text = string.IsNullOrEmpty(data.Platform) ? string.Empty : data.Platform;
            genreTextBox.Text = string.IsNullOrEmpty(data.Genre) ? string.Empty : data.Genre;
        }

        private void DeleteButtonOnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Please put a valid game id to delete");
                return;
            }
            var name = nameTextBox.Text;

            DeleteData(idTextBox.Text);
            DisplayData();
            MessageBox.Show($"Game '{name}' is deleted.");
        }

        private void UpdateButtonOnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Please put a valid game id to update");
                return;
            }

            var id = idTextBox.Text;
            var name = nameTextBox.Text;
            var genre = genreTextBox.Text;
            var platform = platformTextBox.Text;

            UpdateData(id, name, genre, platform);
            DisplayData();
            MessageBox.Show($"Game {id}:{name} is updated.");
        }

        private void DisplayData()
        {
            dataGrid.DataSource = GetDatas();
        }
    }
}