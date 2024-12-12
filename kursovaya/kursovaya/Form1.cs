using kursovaya.Models;
using System;
using System.Drawing.Text;
using kursovaya.Services;

namespace kursovaya
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadComboBox()
        {
            var dbService = new DatabaseService(); // Создаем экземпляр сервиса
            var tables = dbService.GetTables();    // Получаем список записей из таблицы

            // Настраиваем ComboBox
            F.DataSource = tables;
            F.DisplayMember = "rnr"; // Поле для отображения (например, rnr)
            F.ValueMember = "ID";   // Поле для значения (ID)

            b1.DataSource = tables;
            b1.DisplayMember = "b1";
            b1.ValueMember = "ID";

            z2.DataSource = tables;
            z2.DisplayMember = "z2";
            z2.ValueMember = "ID";

            a.DataSource = tables;
            a.DisplayMember = "rmosh";
            a.ValueMember = "ID";

            zp.DataSource = tables;
            zp.DisplayMember = "zp";
            zp.ValueMember = "ID";

            tch.DataSource = tables;
            tch.DisplayMember = "t";
            tch.ValueMember = "ID";

            i.DataSource = tables;
            i.DisplayMember = "i";
            i.ValueMember = "ID";

            F1.DataSource = tables;
            F1.DisplayMember = "mddn";
            F1.ValueMember = "ID";

        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            double Kd;

            Kd = calculateKd();
            double b1_ = Convert.ToDouble(b1.Text);
            double i_ = Convert.ToDouble(i.Text);
            double z1_ = Convert.ToDouble(z1.Text);
            double m_ = Convert.ToDouble(m.Text);
            double z2_ = Convert.ToDouble(z2.Text);
            double a_ = Convert.ToDouble(a.Text);
            double zp_ = Convert.ToDouble(zp.Text);
            double tch_ = Convert.ToDouble(tch.Text);
            double F1_ = Convert.ToDouble(F1.Text);
            double F_ = Convert.ToDouble(F.Text);
            double phic_ = 1.07;
            double phip_ = 1.1;
            double gamma_2 = 50;

            double alpha1_ = calculatedAlpha1(m_, z2_, a_, z1_);
            double z0_ = calculatedz0(z1_, alpha1_);
            double S_ = calculatedS_(m_);
            double h_ = calculatedh_(m_);
            double S1_ = calculatedS1_(S_, h_, gamma_2);
            double n1_ = calculatedn1_();
            double phit_ = calculatedphit(n1_, tch_, i_);
            double Nc_ = calculatedNc_(zp_, n1_, tch_, z1_, F1_);
            //double phit_ = calculatedphit(n1_, tch_);

            double phi_ = phit_ * phic_ * phip_;
            double Kp_ = phi_ * Math.Pow(Nc_, 1.0 / 6.0);
            double sigmaSSd_ = (F_ * Kd) / (z0_ * S1_ * b1_ * 2.65);
            double sigmaSd_ = 0.8 * 5;
            double sigmaSdR_ = sigmaSd_ * Kp_;
            double delta_ = sigmaSSd_ - sigmaSdR_;


            double calculateKd()
            {

                if (comboBox1.Text == "Деревообрабатываемое оборудование")
                {
                    if (comboBox2.Text == "<150")
                    {
                        return 1.1;
                    }
                    if (comboBox2.Text == "<250")
                    {
                        return 1.2;
                    }
                    if (comboBox2.Text == "<400")
                    {
                        return 1.2;
                    }
                }
                if (comboBox1.Text == "Токарные станки и оборудование для типографии")
                {
                    if (comboBox2.Text == "<150")
                    {
                        return 1.2;
                    }
                    if (comboBox2.Text == "<250")
                    {
                        return 1.4;
                    }
                    if (comboBox2.Text == "<400")
                    {
                        return 1.6;
                    }
                }
                if (comboBox1.Text == "Сверильные, расточные, шлифовальные, фрезерные, поперечно-строгательные и долбежные станки")
                {
                    if (comboBox2.Text == "<150")
                    {
                        return 1.3;
                    }
                    if (comboBox2.Text == "<250")
                    {
                        return 1.5;
                    }
                    if (comboBox2.Text == "<400")
                    {
                        return 1.7;
                    }
                }
                if (comboBox1.Text == "Конвейеры ленточные")
                {
                    if (comboBox2.Text == "<150")
                    {
                        return 1.4;
                    }
                    if (comboBox2.Text == "<250")
                    {
                        return 1.5;
                    }
                    if (comboBox2.Text == "<400")
                    {
                        return 1.6;
                    }
                }
                if (comboBox1.Text == "Вентиляторы, подъемники и текстильные оборудование")
                {
                    if (comboBox2.Text == "<150")
                    {
                        return 1.4;
                    }
                    if (comboBox2.Text == "<250")
                    {
                        return 1.6;
                    }
                    if (comboBox2.Text == "<400")
                    {
                        return 1.8;
                    }
                }
                if (comboBox1.Text == "Пластинчатый, ковшовый и элеваторный конвейеры")
                {
                    if (comboBox2.Text == "<150")
                    {
                        return 1.5;
                    }
                    if (comboBox2.Text == "<250")
                    {
                        return 1.6;
                    }
                    if (comboBox2.Text == "<400")
                    {
                        return 1.7;
                    }
                }
                if (comboBox1.Text == "Скребковый и шнековый конвейеры")
                {
                    if (comboBox2.Text == "<150")
                    {
                        return 1.5;
                    }
                    if (comboBox2.Text == "<250")
                    {
                        return 1.7;
                    }
                    if (comboBox2.Text == "<400")
                    {
                        return 1.8;
                    }
                }
                return 1;
            }
            double calculatedAlpha1(double m_, double z2_, double a_, double z1_)
            {

                return 180 - (m_ * (z2_ - z1_) / a_) * 57.3;
            }
            double calculatedz0(double z1_, double alpha1_)
            {
                return (z1_ * alpha1_) / 360;
            }
            double calculatedS_(double m_)
            {
                if (m_ == 2)
                {
                    return 2;
                }
                if (m_ == 3)
                {
                    return 3;
                }
                if (m_ == 4)
                {
                    return 4;
                }
                if (m_ == 5)
                {
                    return 5;
                }
                if (m_ == 6)
                {
                    return 7;
                }
                if (m_ == 7)
                {
                    return 10;
                }
                return 1;
            }
            double calculatedh_(double m_)
            {
                if (m_ == 2)
                {
                    return 1.2;
                }
                if (m_ == 3)
                {
                    return 1.8;
                }
                if (m_ == 4)
                {
                    return 2.4;
                }
                if (m_ == 5)
                {
                    return 3;
                }
                if (m_ == 6)
                {
                    return 4.2;
                }
                if (m_ == 7)
                {
                    return 6;
                }
                return 1;
            }
            double calculatedS1_(double S_, double h_, double gamma_2)
            {
                return 0.5 * h_ * (S_ + 2 * h_ * Math.Tan(gamma_2));
            }
            double calculatedn1_()
            {
                if (m_ == 2)
                {
                    if (z1_ == 12)
                    {
                        return 500;
                    }
                    if (z1_ == 14)
                    {
                        return 3500;
                    }
                    if (z1_ == 16)
                    {
                        return 5000;
                    }
                    if (z1_ == 18)
                    {
                        return 7500;
                    }
                }
                if (m_ == 3)
                {
                    if (z1_ == 12)
                    {
                        return 500;
                    }
                    if (z1_ == 14)
                    {
                        return 1500;
                    }
                    if (z1_ == 16)
                    {
                        return 2500;
                    }
                    if (z1_ == 18)
                    {
                        return 4000;
                    }
                }
                if (m_ == 4)
                {
                    if (z1_ == 12 || z1_ == 13 || z1_ == 14)
                    {
                        return 500;
                    }
                    if (z1_ == 14 || z1_ == 15 || z1_ == 16)
                    {
                        return 1000;
                    }
                    if (z1_ == 16 || z1_ == 17 || z1_ == 18)
                    {
                        return 1500;
                    }
                    if (z1_ == 18 || z1_ == 19 || z1_ == 20)
                    {
                        return 2500;
                    }
                }
                if (m_ == 5)
                {
                    if (z1_ == 16)
                    {
                        return 500;
                    }
                    if (z1_ == 18)
                    {
                        return 1000;
                    }
                    if (z1_ == 20)
                    {
                        return 2000;
                    }
                    if (z1_ == 22)
                    {
                        return 3500;
                    }
                }
                if (m_ == 7)
                {
                    if (z1_ == 20)
                    {
                        return 500;
                    }
                    if (z1_ == 22)
                    {
                        return 1000;
                    }
                    if (z1_ == 24)
                    {
                        return 1500;
                    }
                    if (z1_ == 26)
                    {
                        return 2000;
                    }
                }
                if (m_ == 10)
                {
                    if (z1_ == 20)
                    {
                        return 500;
                    }
                    if (z1_ == 22)
                    {
                        return 1000;
                    }
                    if (z1_ == 24)
                    {
                        return 1500;
                    }
                    if (z1_ == 26)
                    {
                        return 2000;
                    }
                    if (z1_ == 28)
                    {
                        return 2000;
                    }
                }
                return 1;
            }


            double calculatedNc_(double zp_, double n1_, double tch_, double z1_, double F1_)
            {
                if (combobox3.Text == "Постоянный режим работы")
                {
                    return 60 * (z1_ / zp_) * tch_ * n1_;
                }
                else
                {
                    return 60 * (z1_ / zp_) * tch_ * n1_ * Math.Pow((F1_ / F1_), 1.0 / 6.0);
                }
            }
            double calculatedphit(double n1_, double tch_, double i_)
            {
                if (combobox3.Text == "Постоянный режим работы")
                {
                    return Math.Pow(n1_ / Math.Pow(10, 3), 1.0 / 6.0);
                }
                else
                {
                    double rez = 1 / tch_;
                    double gorn2 = 0;
                    for (int i = 0; i < i_; i++)
                    {
                        double gorn = tch_ * Math.Pow(n1_ / Math.Pow(10, 3), 1.0 / 6.0);
                        gorn2 = gorn2 + gorn;
                    }
                    rez = rez * gorn2;
                    return rez;
                }

            }




            Kd1.Text = "Kd1 = " + Kd;
            z01.Text = "z0 = " + z0_;
            S1.Text = "S1 = " + S1_;
            kp1.Text = "Кр = " + Kp_;
            sigmaSSd1.Text = "Сигма*сд = " + sigmaSSd_;
            SigmaSdr1.Text = "Сигмасдр = " + sigmaSdR_;
            delta.Text = "delta_: " + delta_;
            if (delta_ > 0)
            {
                raschet.Text = " Расчет достоверен ";
            }
            else
            {
                raschet.Text = " Расчет не достоверен ";
            }

            try
            {
                // Считываем текст из TextBox
                string resultText = raschet.Text;

                // Получаем выбранный TableId из ComboBox
                if (F.SelectedValue != null)
                {
                    if (F.SelectedValue is int selectedTableId)
                    {
                        var dbService = new DatabaseService();
                        dbService.AddVivod(resultText, selectedTableId); // Добавляем запись в базу

                        MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Очищаем поле
                        //textBoxResult.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Выберите запись из таблицы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите запись из таблицы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void F_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (F.SelectedItem is Table selectedTable)
            {
                //MessageBox.Show($"Вы выбрали: F = {selectedTable.rnr}, ID = {selectedTable.ID}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (b1.SelectedItem is Table selectedTable)
            {
                //MessageBox.Show($"Вы выбрали: b1 = {selectedTable.b1}, ID = {selectedTable.ID}");
            }
        }

        private void z2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (z2.SelectedItem is Table selectedTable)
            {
                //MessageBox.Show($"Вы выбрали: b1 = {selectedTable.b1}, ID = {selectedTable.ID}");
            }
        }

        private void a_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a.SelectedItem is Table selectedTable)
            {
                //MessageBox.Show($"Вы выбрали: b1 = {selectedTable.b1}, ID = {selectedTable.ID}");
            }
        }

        private void zp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zp.SelectedItem is Table selectedTable)
            {
                //MessageBox.Show($"Вы выбрали: b1 = {selectedTable.b1}, ID = {selectedTable.ID}");
            }
        }

        private void tch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tch.SelectedItem is Table selectedTable)
            {
                //MessageBox.Show($"Вы выбрали: b1 = {selectedTable.b1}, ID = {selectedTable.ID}");
            }
        }

        private void i_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (i.SelectedItem is Table selectedTable)
            {
                //MessageBox.Show($"Вы выбрали: b1 = {selectedTable.b1}, ID = {selectedTable.ID}");
            }
        }

        private void F1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (F1.SelectedItem is Table selectedTable)
            {
                //MessageBox.Show($"Вы выбрали: b1 = {selectedTable.b1}, ID = {selectedTable.ID}");
            }
        }

    }
}