using Parser.Core;
using Parser.Core.Postupi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Parser
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;

        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                new PostupiParser()
                );
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;

        }

        //Добавление в ListBoxPars новых данных и обновление LabelProgress
        private void Parser_OnNewData(object arg1, string[] arg2, int x, int page)
        {
            LabelProgress.Text = "Прогресс: " + x + "/" + page + " страниц";
            ListBoxPars.Items.AddRange(arg2);
        }

        //Извещение о завершении работы
        private void Parser_OnCompleted(object obj)
        {
            LabelProgress.Text = "Поиск завершен";
        }
        //Поиск по вузам и направлениям. В данном блоке подключаются фильтры и запускается парсинг страницы
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            string filter = null, city = null, BUrl = null;
            BUrl = "postupi.online/vuzi/";
            if (ComboBoxCity.SelectedIndex == 0) city = null;
            if (ComboBoxCity.SelectedIndex == 1) city = "msk.";
            if (ComboBoxCity.SelectedIndex == 2) city = "spb.";
            if (ComboBoxCity.SelectedIndex == 3) city = "ekaterinburg.";
            if (ComboBoxCity.SelectedIndex == 4) city = "kazan.";
            if (ComboBoxCity.SelectedIndex == 5) city = "nsk.";
            if (ComboBoxCity.SelectedIndex == 6) city = "tomsk.";
            if (ComboBoxCity.SelectedIndex == 7) city = "samara.";
            if (ComboBoxCity.SelectedIndex == 8) city = "rostov.";
            if (ComboBoxCity.SelectedIndex == 9) city = "voronezh.";
            if (ComboBoxCity.SelectedIndex == 10) city = "krasnodar.";
            if (ComboBoxCity.SelectedIndex == 11) city = "krasnoyarsk.";
            if (CheckedListBoxEge.CheckedIndices.Contains(0)) filter += "ege-russkij/";
            if (CheckedListBoxEge.CheckedIndices.Contains(1)) filter += "ege-matematika/";
            if (CheckedListBoxEge.CheckedIndices.Contains(2)) filter += "ege-obshchestvoznanie/";
            if (CheckedListBoxEge.CheckedIndices.Contains(3)) filter += "ege-fizika/";
            if (CheckedListBoxEge.CheckedIndices.Contains(4)) filter += "ege-istoriya/";
            if (CheckedListBoxEge.CheckedIndices.Contains(5)) filter += "ege-inostrannyj/";
            if (CheckedListBoxEge.CheckedIndices.Contains(6)) filter += "ege-informatika/";
            if (CheckedListBoxEge.CheckedIndices.Contains(7)) filter += "ege-biologiya/";
            if (CheckedListBoxEge.CheckedIndices.Contains(8)) filter += "ege-literatura/";
            if (CheckedListBoxEge.CheckedIndices.Contains(9)) filter += "ege-himiya/";
            if (CheckedListBoxEge.CheckedIndices.Contains(10)) filter += "ege-geografiya/";
            if (RadioButtonOchno3.Checked) filter += "forma-ochno/";
            if (RadioButtonZaochno4.Checked) filter += "forma-zaochno/";
            if (RadioButtonDist5.Checked) filter += "forma-distanc/";
            if (RadioButtonBudget6.Checked) filter += "oplata-besplatno/";
            if (RadioButtonPay7.Checked) filter += "oplata-platno/";
           // ListBoxPars.Items.Add("https://"+ city+ BUrl+ filter + "?");
            parser.Settings = new PostupiSettings("https://", city, BUrl, filter+"?");
            parser.Start();
        }

        //Если необходимо очистить ListBoxPars
        private void ButtonClearList_Click(object sender, EventArgs e)
        {
            ListBoxPars.Items.Clear();
        }

        //При первом переключении открывается возможность выбирать фильтры и в случае, если меняется со "специализации" старые фильтры обнуляются
        private void RadioButtonVUZ1_CheckedChanged(object sender, EventArgs e)
        {
            LabelProgress.Text = "Поиск не начат";
            GroupBoxFilterVUZ2.Visible = true;
            GroupBoxFilterProg3.Visible = true;
            GroupBoxFilterEge4.Visible = true;
            GroupBoxFilterCity5.Visible = true;
            ButtonStart.Visible = true;
            ButtonClearList.Visible = true;
            CheckBoxArmy_2.Visible = true;
            CheckBoxDorm_3.Visible = true;
            //  ButtonStop.Visible = true;
            // ButtonClearFilter.Visible = true;
            // CheckBoxGos_1.Checked = false;
            CheckBoxArmy_2.Checked = false;
            CheckBoxDorm_3.Checked = false;
            RadioButtonOchno3.Checked = false;
            RadioButtonZaochno4.Checked = false;
            RadioButtonDist5.Checked = false;
            RadioButtonBudget6.Checked = false;
            RadioButtonPay7.Checked = false;


        }

        //При первом переключении открывается возможность выбирать фильтры и в случае, если меняется с "вузов" старые фильтры обнуляются
        /* private void RadioButtonVUZ1_CheckedChanged(object sender, EventArgs e)
         {
             LabelProgress.Text = "Прогресс: Парсинг не начат";
             GroupBoxFilterVUZ2.Visible = false;
             GroupBoxFilterProg3.Visible = true;
             GroupBoxFilterEge4.Visible = true;
             GroupBoxFilterCity5.Visible = true;
             ButtonStart.Visible = true;
             ButtonClearList.Visible = true;
           //  ButtonStop.Visible = true;
            // ButtonClearFilter.Visible = true;
            // CheckBoxGos_1.Checked = false;
             CheckBoxArmy_2.Checked = false;
             CheckBoxDorm_3.Checked = false;
             RadioButtonOchno3.Checked = false;
             RadioButtonZaochno4.Checked = false;
             RadioButtonDist5.Checked = false;
             RadioButtonBudget6.Checked = false;
             RadioButtonPay7.Checked = false;


         }*/

        //Обнуление всех существующих фильтров
        private void ButtonClearFilter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++) CheckedListBoxEge.SetItemChecked(i, false);
            RadioButtonOchno3.Checked = false;
            RadioButtonZaochno4.Checked = false;
            RadioButtonDist5.Checked = false;
            RadioButtonBudget6.Checked = false;
            RadioButtonPay7.Checked = false;
            //CheckBoxGos_1.Checked = false;
            CheckBoxArmy_2.Checked = false;
            CheckBoxDorm_3.Checked = false;
            ComboBoxCity.Text = "Все города";
        }

        //Остановка парсера при необходимости
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            parser.Abort();
            LabelProgress.Text = "Поиск остановлен";
        }

        //Позволяет осуществить переход на страницу, где возможен осмотр специализаций конкретного вуза.
        //Чтобы осуществить переход, необходимо нажать на ссылку под названием вуза.
        private void ListBoxPars_DoubleClick(object sender, EventArgs e)
        {
            parser.Abort(); 
            switch (RadioButtonVUZ1.Checked) //Чтобы отфильтровать специализации конкретного вуза, необходимо первоначально переключить поиск в "поиск по специализации"
            {
                case true:
                    string BUrl = ListBoxPars.SelectedItem.ToString() + "programmy-obucheniya/bakalavr/?",filter=null; 
                    ListBoxPars.Items.Clear();
                    int i = 0;
                    if (RadioButtonDist5.Checked) filter += "fform=4&"; //Ввиду иных фильтров при поиске направлений в вузе, приходится работать с get-запросами
                    if (RadioButtonBudget6.Checked) filter += "fcost=2&";
                    if (RadioButtonPay7.Checked) filter += "fcost=1&";
                    if (RadioButtonOchno3.Checked) filter += "fform=1&";
                    if (RadioButtonZaochno4.Checked) filter += "fform=2&";
                    if (CheckedListBoxEge.CheckedIndices.Contains(1)) filter += "fexams[" + i++ + "]=1&";
                    if (CheckedListBoxEge.CheckedIndices.Contains(7)) filter += "fexams[" + i++ + "]=3&";
                    if (CheckedListBoxEge.CheckedIndices.Contains(10)) filter += "fexams[" + i++ + "]=4&";
                    if (CheckedListBoxEge.CheckedIndices.Contains(5)) filter += "fexams[" + i++ + "]=5&";
                    if (CheckedListBoxEge.CheckedIndices.Contains(6)) filter += "fexams[" + i++ + "]=6&";
                    if (CheckedListBoxEge.CheckedIndices.Contains(4)) filter += "fexams[" + i++ + "]=7&";
                    if (CheckedListBoxEge.CheckedIndices.Contains(8)) filter += "fexams[" + i++ + "]=8&";
                    if (CheckedListBoxEge.CheckedIndices.Contains(2)) filter += "fexams[" + i++ + "]=9&";
                    if (CheckedListBoxEge.CheckedIndices.Contains(0)) filter += "fexams["+ i++ + "]=10&";
                    if (CheckedListBoxEge.CheckedIndices.Contains(3)) filter += "fexams[" + i++ + "]=11&";
                    if (CheckedListBoxEge.CheckedIndices.Contains(9)) filter += "fexams[" + i++ + "]=12&";
                    //ListBoxPars.Items.Add(BUrl+ filter);
                    parser.Settings = new PostupiSettings(null, null, BUrl, filter);
                    parser.Start();
                    break;
                case false:
                    MessageBox.Show("Переключите поиск на специальности и \tвыберите фильтры прежде чем продолжить");
                    break;
            }
        }

        private void GroupBoxFilterVUZ2_Enter(object sender, EventArgs e)
        {

        }

        private void LabelProgress_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
