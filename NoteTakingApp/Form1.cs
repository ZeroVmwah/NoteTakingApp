using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadNotes();
        }

        private void LoadNotes()
        {
            saved.Items.Clear();

            using (SqlConnection connection = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                string query = "SELECT Title, ContentNote, Timestamp FROM Notes";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Title"].ToString());
                    item.SubItems.Add(reader["ContentNote"].ToString());
                    item.SubItems.Add(reader["Timestamp"].ToString());
                    saved.Items.Add(item);
                }

                reader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                string insertQuery = "INSERT INTO Notes VALUES (@Title, @ContentNote, @Timestamp)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                // Set parameters based on selected values
                insertCmd.Parameters.AddWithValue("@Title", title.Text);
                insertCmd.Parameters.AddWithValue("@ContentNote", note.Text);
                insertCmd.Parameters.AddWithValue("@Timestamp", times.Text);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Note Saved Successfully!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            title.Clear();
            note.Clear();
            times.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saved.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = saved.SelectedItems[0];
                string title = selectedItem.Text;

                try
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
                    {
                        string query = "DELETE FROM Notes WHERE Title = @Title";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Title", title);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Note deleted successfully.");
                            LoadNotes(); // Refresh the list of notes after deletion
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete note.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting note: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a note to delete.");
            }
        }


        private void times_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(times.Text) && (!DateTime.TryParse(times.Text, out DateTime stamp)))
            {
                MessageBox.Show("Invalid TimeStamp!!");
            }
        }

        private void title_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(title.Text))
            {
                MessageBox.Show("Invalid Title!!");
            }
        }

        private void note_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(note.Text))
            {
                MessageBox.Show("Note cannot be empty!!");
            }
        }
    }


}