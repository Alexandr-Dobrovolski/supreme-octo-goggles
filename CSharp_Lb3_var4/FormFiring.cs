using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharp_Lb3_Var4
{
    public partial class FormFactory
    {
        TextBox firingTextBoxIndividualNumber;
        Form formFiring;
        int firingMode;

        //ініціалізація форми найму/звільнення працівників
        public void initializeFormFiring(int mode)
        {
            //if (arr.Count == 0)
            //    MessageBox.Show("В базі відсутні заводи!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //{
                firingMode = mode;
                formFiring = new Form()
                {
                    Width = 400,
                    Height = 150,
                    StartPosition = FormStartPosition.CenterScreen,
                    MaximizeBox = false,
                    MinimizeBox = false,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    Text = "Найм/звільнення працівників"
                };
                Label labelIndividualCode = new Label()
                {
                    Location = new Point(20, 20),
                    Width = 120,
                    Text = "Податковий номер"
                };
                formFiring.Controls.Add(labelIndividualCode);
                firingTextBoxIndividualNumber = new TextBox()
                {
                    Location = new Point(150, 20),
                    Width = 200
                };
                formFiring.Controls.Add(firingTextBoxIndividualNumber);

                Button buttonDone = new Button()
                {
                    Location = new Point(150, 50),
                    Width = 80,
                    Height = 30,
                    Text = "Done"
                };
                buttonDone.Click += new System.EventHandler(buttonDoneFiringOnClick);
                formFiring.Controls.Add(buttonDone);

                formFiring.ShowDialog();
            //}
        }

        private void buttonDoneFiringOnClick(object sender, EventArgs eventArgs)
        {
            if (arr.Count == 0)
                MessageBox.Show("В базі ще намає жодного завода та співробітників!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (firingTextBoxIndividualNumber.Text == "")
                MessageBox.Show("Введіть значення!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (checkIndividualNumber(firingTextBoxIndividualNumber.Text))
                MessageBox.Show("Неправильний формат даних!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int index = findPerson(firingTextBoxIndividualNumber.Text);
                if (index == -1)
                    MessageBox.Show("Такого працівника не знайдено!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    removePerson(index, firingMode, firingTextBoxIndividualNumber.Text);
                    MessageBox.Show("Успішне видалення!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    arr.ElementAt(index).amountCraftsmen = arr.ElementAt(index).GetCountMasters;
                    arr.ElementAt(index).amountWorkers = arr.ElementAt(index).GetCountWorkers;
                    formFiring.Close();
                }
            }
        }
    }
}
