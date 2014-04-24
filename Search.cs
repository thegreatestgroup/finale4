using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Finale
{
    class Search
    {

        public DataTable SearchFor(Song temp)
        {
            int counter = 0;

            string query = "SELECT Song.Name AS song, Album.Name AS album, Artist.Name AS artist, Composer.Name AS composer, Genre.Name AS genre, Song.Year AS year " + "FROM Song" + 
                " INNER JOIN AlbumSong ON AlbumSong.SongID = Song.ID " +
                " INNER JOIN Album ON Album.ID = AlbumSong.AlbumID " +
                " INNER JOIN Artist ON Artist.ArtistID = Song.ArtistID " +
                " INNER JOIN Composer ON Composer.ID = Song.ComposerID " +
                " INNER JOIN Genre ON Genre.ID = Song.GenreID WHERE";


            if (temp.Title.IsDirty)
            {
                query += (" song LIKE '%" + temp.Title.Value + "%'");
                counter ++;
            }
            if (temp.Artist.IsDirty)
            {
                if (counter > 0)
                    query += " AND";
                query += (" artist LIKE '%" + temp.Artist.Value + "%'");
                counter ++;
            }
            if (temp.Album.IsDirty)
            {
                if (counter > 0)
                    query += " AND";
                query += ("album LIKE '%" + temp.Album.Value + "%'");
            }




            System.Data.DataTable table;


            using (System.Data.SqlClient.SqlConnection _con = new System.Data.SqlClient.SqlConnection("user id=GreatestGroup;" + "password=password; server=champlainmssql.cabect4hsdzs.us-east-1.rds.amazonaws.com,7788;" + 
                //"Trusted_Connection=yes;" 
            "database=Greatest; " + "connection timeout=30"))
            {
                using (System.Data.SqlClient.SqlCommand _cmd = new System.Data.SqlClient.SqlCommand(query, _con))
                {
                    table = new System.Data.DataTable("SearchResults");

                    System.Data.SqlClient.SqlDataAdapter _dap = new System.Data.SqlClient.SqlDataAdapter(_cmd);

                    _con.Open();
                    _dap.Fill(table);
                    _con.Close();
                }
            }


            return table;
        }

    }
}
