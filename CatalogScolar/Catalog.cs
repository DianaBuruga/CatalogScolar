using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CatalogScolar
{
    public partial class Catalog : Form
    {
        String connectionString;
        DataTable dataTable;
        public Catalog()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CatalogScolar.mdf;Integrated Security=True;Connect Timeout=30";
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }
        private void AfisareElev()
        {
            string comanda = $"SELECT * FROM ELEVI " +
                            $"WHERE Nume = '{nume.Text}' AND Prenume = '{prenume.Text}'";
            SelecteazaSiAfiseazaDate(comanda);
        }
        private void cautaElev_Click(object sender, EventArgs e)
        {
            AfisareElev();
        }
        private void adaugaElev_Click(object sender, EventArgs e)
        {
            string comanda = "INSERT INTO ELEVI(Nume, Prenume, CNP, Adresa) " +
                             $"VALUES ('{nume.Text}', '{prenume.Text}', '{cnp.Text}', '{adresa.Text}')";
            ExecutaComanda(comanda);
            AfisareElev();
        }
        private void adaugaNota_Click(object sender, EventArgs e)
        {
            string comanda = "INSERT INTO Note(Nota, Materie, Data, Profesor, IdElev) " +
                             $"VALUES ('{nota.Text}', '{materie.Text}', '{data.Text}', '{profesor.Text}','{idElev.Text}')";
            ExecutaComanda(comanda);
            vizualizareNoteElevLaMaterie();

        }

        private void modificaElev_Click(object sender, EventArgs e)
        {
            string comanda = "UPDATE ELEVI " +
                             $"SET NUME = '{nume.Text}', Prenume = '{prenume.Text}', Adresa = '{adresa.Text}' " +
                             $"WHERE Id = '{idElev.Text}'";
            ExecutaComanda(comanda); 
            AfisareElev();
        }
        private void modificaNota_Click(object sender, EventArgs e)
        {
            string comanda = "UPDATE Note " +
                             $"SET Nota ='{nota.Text}', Materie = '{materie.Text}', Data = '{data.Text}', Profesor = '{profesor.Text}' " +
                             $"WHERE IdElev = '{idElev.Text}'";
            ExecutaComanda(comanda);
            vizualizareNoteElevLaMaterie();
        }

        private void ExecutaComanda(string comanda)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(comanda, sqlConnection))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception eroare)
            {
                MessageBox.Show(eroare.Message);
            }
        }
        private void SelecteazaSiAfiseazaDate(string comanda)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(comanda, sqlConnection))
                    {
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            dataTable = new DataTable();
                            dataTable.Load(sqlDataReader);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception eroare)
            {
                MessageBox.Show(eroare.Message);
            }
        }
        private void AfisareElevi()
        {
            string comanda = "SELECT * FROM ELEVI";
            SelecteazaSiAfiseazaDate(comanda);
        }
        private void vizualizareElevi_Click(object sender, EventArgs e)
        {
            AfisareElevi();
        }

        private void stergeElev_Click(object sender, EventArgs e)
        {
            string comanda = $"DELETE FROM ELEVI WHERE Id = '{idElev.Text}'";
            ExecutaComanda(comanda);
            AfisareElevi();
        }
        private void StergeNote_Click(object sender, EventArgs e)
        {
            string comanda = "DELETE FROM Note " +
                $"WHERE Nota ='{nota.Text}' AND Materie = '{materie.Text}'AND " +
                $"Data = '{data.Text}' AND Profesor = '{profesor.Text}' AND IdElev = {idElev.Text}";
            ExecutaComanda(comanda);
            vizualizareNoteElevLaMaterie();
        }

        private void vizualizareNote_Click(object sender, EventArgs e)
        {
            string comanda = $"SELECT ELEVI.Id, Nume, Prenume, Nota, Materie, Data, Profesor FROM ELEVI JOIN NOTE ON ELEVI.Id=NOTE.IdElev";
            SelecteazaSiAfiseazaDate(comanda);
        }


        private void noteElevLaMaterie_Click(object sender, EventArgs e)
        {
            vizualizareNoteElevLaMaterie();
        }
        private void vizualizareNoteElevLaMaterie()
        {
            string comanda = "SELECT ELEVI.Id, Nume, Prenume, Nota, Materie, Data, Profesor FROM ELEVI JOIN NOTE ON ELEVI.Id=NOTE.IdElev " +
                            $"WHERE Nume = '{nume.Text}' AND Prenume = '{prenume.Text}' AND Materie ='{materie.Text}'";
            SelecteazaSiAfiseazaDate(comanda);
        }
        private void vizualizareNoteElev_Click(object sender, EventArgs e)
        {
            string comanda = "SELECT ELEVI.Id, Nume, Prenume, Nota, Materie, Data, Profesor FROM ELEVI JOIN NOTE ON ELEVI.Id=NOTE.IdElev " +
                            $"WHERE Nume = '{nume.Text}' AND Prenume = '{prenume.Text}'";
            SelecteazaSiAfiseazaDate(comanda);
        }

        private void noteLaMaterie_Click(object sender, EventArgs e)
        {
            string comanda = "SELECT ELEVI.Id, Nume, Prenume, Nota, Materie, Data, Profesor FROM ELEVI JOIN NOTE ON ELEVI.Id=NOTE.IdElev " +
                             $"WHERE Materie ='{materie.Text}'";
            SelecteazaSiAfiseazaDate(comanda);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
