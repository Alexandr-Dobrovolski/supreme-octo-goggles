using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp_Lb3_Var4
{
    //форма порівняння заводів
    public partial class FormFactory
    {
        Form formComparison;
        ComboBox comboBoxComparison1, comboBoxComparison2;
        DataGridView dataGridViewComparison;

        public void initializeFormComparison()
        {
            formComparison = new Form()
            {
                Width = 625,
                Height = 400,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
                Text = "Порівняння заводів"
            };
            formComparison.Show();

            Label label1 = new Label()
            {
                Location = new Point(20, 20),
                Text = "Завод 1"
            };
            formComparison.Controls.Add(label1);

            comboBoxComparison1 = new ComboBox()
            {
                Location = new Point(20, 50),
                Width = 280
            };
            addComboBoxInfo(comboBoxComparison1);
            formComparison.Controls.Add(comboBoxComparison1);

            Label label2 = new Label()
            {
                Location = new Point(310, 20),
                Text = "Завод 2"
            };
            formComparison.Controls.Add(label2);

            comboBoxComparison2 = new ComboBox()
            {
                Location = new Point(310, 50),
                Width = 280
            };
            addComboBoxInfo(comboBoxComparison2);
            formComparison.Controls.Add(comboBoxComparison2);

            Button buttonComparable = new Button()
            {
                Location = new Point(265, 80),
                Width = 80,
                Height = 30,
                Text = "Comparable"
            };
            buttonComparable.Click += new System.EventHandler(buttonComparableOnClick);
            formComparison.Controls.Add(buttonComparable);

            dataGridViewComparison = new DataGridView()
            {
                Location = new Point(20, 120),
                Width = 570,
                Height = 220,
                ColumnCount = 4,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            };
            dataGridViewComparison.Columns[0].HeaderText = "Дані";
            dataGridViewComparison.Columns[1].HeaderText = "Завод 1";
            dataGridViewComparison.Columns[2].HeaderText = "><=";
            dataGridViewComparison.Columns[3].HeaderText = "Завод 2";
            formComparison.Controls.Add(dataGridViewComparison);
        }

        private void addInfoToDataGridViewComparison(string sign1, string sign2, string sign3)
        {
            dataGridViewComparison.Rows.Clear();
            dataGridViewComparison.Rows.Add("Назви", arr.ElementAt(comboBoxComparison1.SelectedIndex).factoryName, "", arr.ElementAt(comboBoxComparison2.SelectedIndex).factoryName);
            dataGridViewComparison.Rows.Add(
                "Кількість робітників",
                arr.ElementAt(comboBoxComparison1.SelectedIndex).amountWorkers,
                sign1,
                arr.ElementAt(comboBoxComparison2.SelectedIndex).amountWorkers
                );
            dataGridViewComparison.Rows.Add(
                "К-сть майстрів",
                arr.ElementAt(comboBoxComparison1.SelectedIndex).amountCraftsmen,
                sign2,
                arr.ElementAt(comboBoxComparison2.SelectedIndex).amountCraftsmen
                );
            dataGridViewComparison.Rows.Add(
                "К-сть цехів",
                arr.ElementAt(comboBoxComparison1.SelectedIndex).numberWorkshops,
                sign3,
                arr.ElementAt(comboBoxComparison2.SelectedIndex).numberWorkshops
                );
        }

        private void buttonComparableOnClick(object sender, EventArgs eventArgs)
        {
            if (comboBoxComparison1.SelectedIndex == -1 || comboBoxComparison2.SelectedIndex == -1)
                MessageBox.Show("Оберіть заводи!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (comboBoxComparison1.SelectedIndex == comboBoxComparison2.SelectedIndex)
                MessageBox.Show("Не можна обирати однакові заводи для порівняння!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int resultComparable = arr.ElementAt(comboBoxComparison1.SelectedIndex).CompareTo(arr.ElementAt(comboBoxComparison2.SelectedIndex));

                switch (resultComparable)
                {
                    case 1:
                        addInfoToDataGridViewComparison(">", ">", ">");
                        break;
                    case 2:
                        addInfoToDataGridViewComparison("<", ">", ">");
                        break;
                    case 3:
                        addInfoToDataGridViewComparison(">", "<", ">");
                        break;
                    case 4:
                        addInfoToDataGridViewComparison(">", ">", "<");
                        break;
                    case 5:
                        addInfoToDataGridViewComparison("<", "<", ">");
                        break;
                    case 6:
                        addInfoToDataGridViewComparison(">", "<", "<");
                        break;
                    case 7:
                        addInfoToDataGridViewComparison("<", ">", "<");
                        break;
                    case 8:
                        addInfoToDataGridViewComparison("<", "<", "<");
                        break;
                    case 9:
                        addInfoToDataGridViewComparison("=", ">", ">");
                        break;
                    case 10:
                        addInfoToDataGridViewComparison("=", ">", "<");
                        break;
                    case 11:
                        addInfoToDataGridViewComparison("=", "<", ">");
                        break;
                    case 12:
                        addInfoToDataGridViewComparison("=", "<", "<");
                        break;
                    case 13:
                        addInfoToDataGridViewComparison(">", "=", ">");
                        break;
                    case 14:
                        addInfoToDataGridViewComparison("<", "=", ">");
                        break;
                    case 15:
                        addInfoToDataGridViewComparison(">", "=", "<");
                        break;
                    case 16:
                        addInfoToDataGridViewComparison("<", "=", "<");
                        break;
                    case 17:
                        addInfoToDataGridViewComparison(">", ">", "=");
                        break;
                    case 18:
                        addInfoToDataGridViewComparison(">", "<", "=");
                        break;
                    case 19:
                        addInfoToDataGridViewComparison("<", ">", "=");
                        break;
                    case 20:
                        addInfoToDataGridViewComparison("<", "<", "=");
                        break;
                    case 21:
                        addInfoToDataGridViewComparison("=", "=", ">");
                        break;
                    case 22:
                        addInfoToDataGridViewComparison("=", "=", "<");
                        break;
                    case 23:
                        addInfoToDataGridViewComparison("=", "=", "=");
                        break;
                }
            }
        }
    }
}
