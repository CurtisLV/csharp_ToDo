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
            //
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            //
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
