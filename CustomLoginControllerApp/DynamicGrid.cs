using System.ComponentModel;
using System.Data;

namespace CustomLoginControllerApp
{
    public partial class DynamicGrid : Form, INotifyPropertyChanged
    {
        #region Data members

        private int _rows;
        private int _columns;
        private DataTable? dt;

        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Properties

        public int Rows
        {
            get { return _rows; }
            set
            {
                if (_rows != value)
                {
                    _rows = value;
                    OnPropertyChanged(nameof(Rows));
                    GenerateGrid();
                }
            }
        }
        public int Columns
        {
            get { return _columns; }
            set
            {
                if (_columns != value)
                {
                    _columns = value;
                    OnPropertyChanged(nameof(Columns));
                    GenerateGrid();
                }
            }
        }

        #endregion

        public DynamicGrid()
        {
            InitializeComponent();

            // Set up data binding for text boxes
            txtRows.DataBindings.Add("Text", this, nameof(Rows), true, DataSourceUpdateMode.OnPropertyChanged);
            txtColumns.DataBindings.Add("Text", this, nameof(Columns), true, DataSourceUpdateMode.OnPropertyChanged);

            // Initial values
            Rows = 1;
            Columns = 1;
        }

        private void txtRows_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtRows.Text, out int rows) && rows > 0)
            {
                Rows = rows;
            }
        }

        private void txtColumns_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtColumns.Text, out int columns) && columns > 0)
            {
                Columns = columns;
            }
        }

        private void GenerateGrid()
        {
            // Create a new DataTable to avoid column accumulation
            dt = new DataTable();

            // First add all columns
            for (int col = 0; col < Columns; col++)
            {
                dt.Columns.Add($"Column {col + 1}");
            }

            // Then add all rows
            for (int row = 0; row < Rows; row++)
            {
                DataRow newRow = dt.NewRow();
                dt.Rows.Add(newRow);
            }

            // Set the DataGridView's data source
            dataGridView1.DataSource = dt;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
