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
        TextBox hiringTextBoxName, hiringTextBoxSurname, hiringTextBoxPatronymic, hiringTextBoxIndividualNumber,
            hiringTextBoxNumberWorkshop, hiringTextBoxCountSertificates;
        RadioButton hiringRadioButtonHigherTrue, hiringRadioButtonHigherFalse;
        Form formHiring;
        ComboBox comboBoxHiringFactories;
        int hiringStatusWork, hiringArrayIndex, hiringCountPeople;
        string hiringMode;

        //ініціалізація форми найму/звільнення працівників
        public void initializeFormHiring(int mode1, string mode2, bool isEnableComboBox, int arrayIndex, int countPeople)
        {
            if (arr.Count == 0)
                MessageBox.Show("В базі відсутні заводи!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                hiringStatusWork = mode1;
                hiringMode = mode2;
                hiringArrayIndex = arrayIndex;
                hiringCountPeople = countPeople;

                formHiring = new Form()
                {
                    Width = 400,
                    Height = 350,
                    StartPosition = FormStartPosition.CenterScreen,
                    MaximizeBox = false,
                    MinimizeBox = false,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    Text = "Найм працівників"
                };
                Label hiringComboBoxLabel = new Label()
                {
                    Location = new Point(20, 25),
                    Width = 120,
                    Text = "Список заводів"
                };
                comboBoxHiringFactories = new ComboBox()
                {
                    Location = new Point(150, 20),
                    Width = 200
                };
                addComboBoxInfo(comboBoxHiringFactories);
                if (isEnableComboBox)
                {
                    formHiring.Controls.Add(comboBoxHiringFactories);
                    formHiring.Controls.Add(hiringComboBoxLabel);
                }

                Label labelSurname = new Label()
                {
                    Location = new Point(20, 55),
                    Width = 120,
                    Text = "Прізвище"
                };
                formHiring.Controls.Add(labelSurname);
                hiringTextBoxSurname = new TextBox()
                {
                    Location = new Point(150, 50),
                    Width = 200
                };
                formHiring.Controls.Add(hiringTextBoxSurname);

                Label labelName = new Label()
                {
                    Location = new Point(20, 85),
                    Width = 120,
                    Text = "Ім'я"
                };
                formHiring.Controls.Add(labelName);
                hiringTextBoxName = new TextBox()
                {
                    Location = new Point(150, 80),
                    Width = 200
                };
                formHiring.Controls.Add(hiringTextBoxName);

                Label labelPatronymic = new Label()
                {
                    Location = new Point(20, 115),
                    Width = 120,
                    Text = "По-батькові"
                };
                formHiring.Controls.Add(labelPatronymic);
                hiringTextBoxPatronymic = new TextBox()
                {
                    Location = new Point(150, 110),
                    Width = 200
                };
                formHiring.Controls.Add(hiringTextBoxPatronymic);

                Label labelIndividualNumber = new Label()
                {
                    Location = new Point(20, 145),
                    Width = 120,
                    Text = "Податковий номер"
                };
                formHiring.Controls.Add(labelIndividualNumber);
                hiringTextBoxIndividualNumber = new TextBox()
                {
                    Location = new Point(150, 140),
                    Width = 200
                };
                formHiring.Controls.Add(hiringTextBoxIndividualNumber);

                Label labelNumberWorkshop = new Label()
                {
                    Location = new Point(20, 175),
                    Width = 120,
                    Text = "Номер цеху"
                };
                formHiring.Controls.Add(labelNumberWorkshop);
                hiringTextBoxNumberWorkshop = new TextBox()
                {
                    Location = new Point(150, 170),
                    Width = 200
                };
                formHiring.Controls.Add(hiringTextBoxNumberWorkshop);

                Label labelEducation = new Label()
                {
                    Location = new Point(20, 205),
                    Width = 120,
                    Text = "Наявність освіти"
                };
                GroupBox educationGroupBox = new GroupBox()
                {
                    Location = new Point(150, 195),
                    Width = 115,
                    Height = 40
                };
                hiringRadioButtonHigherTrue = new RadioButton()
                {
                    Location = new Point(10, 10),
                    Text = "Так",
                    Width = 50,
                    Checked = true
                };
                educationGroupBox.Controls.Add(hiringRadioButtonHigherTrue);
                hiringRadioButtonHigherFalse = new RadioButton()
                {
                    Location = new Point(70, 10),
                    Text = "Ні",
                    Width = 40,
                };
                educationGroupBox.Controls.Add(hiringRadioButtonHigherFalse);

                Label labelCertificates = new Label()
                {
                    Location = new Point(20, 205),
                    Width = 120,
                    Text = "К-сть сертифікатів"
                };
                hiringTextBoxCountSertificates = new TextBox()
                {
                    Location = new Point(150, 200),
                    Width = 200
                };

                if (mode1 == 1)
                {
                    formHiring.Controls.Add(labelEducation);
                    formHiring.Controls.Add(educationGroupBox);
                }
                else
                {
                    formHiring.Controls.Add(labelCertificates);
                    formHiring.Controls.Add(hiringTextBoxCountSertificates);
                }

                Button buttonDone = new Button()
                {
                    Location = new Point(150, 240),
                    Width = 80,
                    Height = 30,
                    Text = "Done"
                };
                buttonDone.Click += new System.EventHandler(buttonDoneHiringOnClick);
                formHiring.Controls.Add(buttonDone);

                formHiring.ShowDialog();
            }
        }

        private void buttonDoneHiringOnClick(object sender, EventArgs eventArgs)
        {
            int parseNumberWorkshop, parseCountSertificates;
            Int32.TryParse(hiringTextBoxNumberWorkshop.Text, out parseNumberWorkshop);
            Int32.TryParse(hiringTextBoxCountSertificates.Text, out parseCountSertificates);

            if (hiringTextBoxSurname.Text == "" || hiringTextBoxName.Text == "" ||
                hiringTextBoxPatronymic.Text == "" || hiringTextBoxIndividualNumber.Text == "" ||
                hiringTextBoxNumberWorkshop.Text == "" || (hiringTextBoxCountSertificates.Text == "" && hiringStatusWork == 2))
                MessageBox.Show("Недостатньо даних!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (hiringTextBoxIndividualNumber.Text.Length != 10)
                MessageBox.Show("Не правильна довжина податкового номера!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (checkIndividualNumber(hiringTextBoxIndividualNumber.Text))
                MessageBox.Show("Податковий номер не може мати в собі літери!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (checkIndividualNumberRepeat(hiringTextBoxIndividualNumber.Text))
                MessageBox.Show("Такий податковий номер вже існує!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (parseNumberWorkshop <= 0)
                MessageBox.Show("Неправильний формат номера цеху!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (parseCountSertificates <= 0 && hiringStatusWork == 2)
                MessageBox.Show("Неправильний формат кількості сертифікатів!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (hiringStatusWork == 1)
                {
                    Worker saveWorker = new Worker()
                    {
                        surname = hiringTextBoxSurname.Text,
                        name = hiringTextBoxName.Text,
                        patronymic = hiringTextBoxPatronymic.Text,
                        taxNumber = hiringTextBoxIndividualNumber.Text,
                        numberWorkshop = parseNumberWorkshop
                    };
                    if (hiringRadioButtonHigherTrue.Checked)
                        saveWorker.haveHigherTechnicalEducation = true;
                    else
                        saveWorker.haveHigherTechnicalEducation = false;
                    if (hiringMode == "New")
                    {
                        arr.ElementAt(hiringArrayIndex).listWorkers.Add(saveWorker);
                        arr.ElementAt(hiringArrayIndex).amountWorkers = arr.ElementAt(hiringArrayIndex).GetCountWorkers;
                    }
                    else
                    {
                        if (comboBoxHiringFactories.SelectedIndex == -1)
                            MessageBox.Show("Оберіть завод!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            arr.ElementAt(comboBoxHiringFactories.SelectedIndex).listWorkers.Add(saveWorker);
                            arr.ElementAt(comboBoxHiringFactories.SelectedIndex).amountWorkers = arr.ElementAt(hiringArrayIndex).GetCountWorkers;
                        }
                    }
                }
                else
                {
                    Master saveMaster = new Master()
                    {
                        surname = hiringTextBoxSurname.Text,
                        name = hiringTextBoxName.Text,
                        patronymic = hiringTextBoxPatronymic.Text,
                        taxNumber = hiringTextBoxIndividualNumber.Text,
                        numberWorkshop = parseNumberWorkshop,
                        countCertificates = parseCountSertificates
                    };
                    if (hiringMode == "New")
                    {
                        arr.ElementAt(hiringArrayIndex).listMasters.Add(saveMaster);
                        arr.ElementAt(hiringArrayIndex).amountCraftsmen = arr.ElementAt(hiringArrayIndex).GetCountMasters;
                    }
                    else
                    {
                        if (comboBoxHiringFactories.SelectedIndex == -1)
                            MessageBox.Show("Оберіть завод!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            arr.ElementAt(comboBoxHiringFactories.SelectedIndex).listMasters.Add(saveMaster);
                            arr.ElementAt(comboBoxHiringFactories.SelectedIndex).amountCraftsmen = arr.ElementAt(hiringArrayIndex).GetCountMasters;
                        }
                    }
                }
                Person savePerson = new Person()
                {
                    surname = hiringTextBoxSurname.Text,
                    name = hiringTextBoxName.Text,
                    patronymic = hiringTextBoxPatronymic.Text,
                    taxNumber = hiringTextBoxIndividualNumber.Text,
                    numberWorkshop = parseNumberWorkshop,
                };
                bool spesialBrake = false;
                if (hiringMode == "New")
                    arr.ElementAt(hiringArrayIndex).listPeople.Add(savePerson);
                else
                {
                    if (comboBoxHiringFactories.SelectedIndex == -1)
                        spesialBrake = true;
                    else
                        arr.ElementAt(comboBoxHiringFactories.SelectedIndex).listPeople.Add(savePerson);
                }
                hiringCountPeople--;
                if (hiringCountPeople > 0)
                {
                    hiringTextBoxSurname.Text = "";
                    hiringTextBoxName.Text = "";
                    hiringTextBoxPatronymic.Text = "";
                    hiringTextBoxIndividualNumber.Text = "";
                    hiringTextBoxNumberWorkshop.Text = "";
                    hiringTextBoxCountSertificates.Text = "";
                    hiringRadioButtonHigherTrue.Checked = true;
                }
                else if (!spesialBrake)
                    formHiring.Close();
            }
        }
    }
}
