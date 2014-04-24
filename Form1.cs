using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region Display All Songs
            string query = "SELECT Song.Name AS song, Album.Name AS album, Artist.Name AS artist, Composer.Name AS composer, Genre.Name AS genre, Song.Year AS year " +
                         " FROM Song " +
                         " INNER JOIN AlbumSong ON AlbumSong.SongID = Song.ID " +
                         " INNER JOIN Album ON Album.ID = AlbumSong.AlbumID " +
                         " INNER JOIN Artist ON Artist.ArtistID = Song.ArtistID " +
                         " INNER JOIN Composer ON Composer.ID = Song.ComposerID " +
                         " INNER JOIN Genre ON Genre.ID = Song.GenreID";

            using (var connection = new SqlConnection("user id=GreatestGroup;" +
                                                   "password=password;server=champlainmssql.cabect4hsdzs.us-east-1.rds.amazonaws.com,7788;" +
                                                   "database=Champlain Music Store; " +
                                                   "connection timeout=30"))
            using (var command = new SqlCommand(query, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = myTable;
            }
            #endregion
        }

        private void submitRemoveSome_Click(object sender, EventArgs e)
        {
            SqlConnection _con = new SqlConnection("user id=GreatestGroup;" +
                                                   "password=password;server=champlainmssql.cabect4hsdzs.us-east-1.rds.amazonaws.com,7788;" +
                                                   "database=Champlain Music Store; " +
                                                   "connection timeout=30");
            _con.Open();
               Console.WriteLine(this.removeSongName.Text);
            _con.Close();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
          
            var temp = new Song();

            if (textBox1.Text != "")
            {
                temp.Title.Value = textBox1.Text;
            }

            if (textBox2.Text != "")
            {
                temp.Artist.Value = textBox2.Text;
            }

            if (textBox3.Text != "")
            {
                temp.Album.Value = textBox3.Text;
            }

            DataTable searchResults = SearchFor(temp);


            foreach (DataRow row in searchResults.Rows)
            {
                Song tmp = new Song();

                searchResults.loadRow(row);

                textBox1.Text += "Song: " + tmp.Title.Value + Environment.NewLine;
                textBox1.Text += "Last Name: " + tmp.Artist.Value + Environment.NewLine;
                textBox1.Text += "Pet Name: " + tmp.Artist.Value + Environment.NewLine + Environment.NewLine;
            }

        }

        private DataTable SearchFor(Song temp)
        {
            throw new NotImplementedException();
        }
        */
    }
}
