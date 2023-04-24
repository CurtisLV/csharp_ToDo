using System.Data;

namespace csharp_ToDo
{
    public partial class ToDoListForm : Form
    {
        public ToDoListForm()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            // Create columns

            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            // Point our datagridview to data source
            todoListView.DataSource = todoList;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // fill text fields with data from
            titleTextBox.Text = todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[
                0
            ].ToString();
            descriptionTextBox.Text = todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[
                1
            ].ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
