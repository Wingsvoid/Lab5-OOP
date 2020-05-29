using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CardEmployee
{
    /// <summary>
    /// Логика взаимодействия для InfoEmployee.xaml
    /// </summary>
    public partial class InfoEmployee : UserControl
    {
        public InfoEmployee()
        {
            InitializeComponent();
        }

        //Surname
        public static new readonly DependencyProperty SurnameProperty = DependencyProperty.Register(
            "surnameEmployee",
            typeof(string),
            typeof(InfoEmployee),
            new PropertyMetadata(string.Empty, SurnameChanged));

        public string surnameEmployee
        {
            get { return (string)GetValue(SurnameProperty); }
            set { SetValue(SurnameProperty, value); }
        }

        private static void SurnameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var surnameObj = obj as InfoEmployee;
            surnameObj.surname.Text = surnameObj.surnameEmployee.ToString();
        }
        
        //Name
        public new static readonly DependencyProperty NameProperty = DependencyProperty.Register(
            "nameEmployee",
            typeof(string),
            typeof(InfoEmployee),
            new PropertyMetadata(string.Empty, NameChanged));

        public string nameEmployee
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        private static void NameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var nameObj = obj as InfoEmployee;
            nameObj.name.Text = nameObj.nameEmployee.ToString();
        }

        //Age
        public static new readonly DependencyProperty AgeProperty = DependencyProperty.Register(
            "ageEmployee",
            typeof(string),
            typeof(InfoEmployee),
            new PropertyMetadata(string.Empty, AgeChanged));

        public string ageEmployee
        {
            get { return (string)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        private static void AgeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var ageObj = obj as InfoEmployee;
            ageObj.age.Text = ageObj.ageEmployee.ToString();
        }

        //Position
        public static new readonly DependencyProperty PositionProperty = DependencyProperty.Register(
            "positionEmployee",
            typeof(string),
            typeof(InfoEmployee),
            new PropertyMetadata(string.Empty, PositionChanged));

        public string positionEmployee
        {
            get { return (string)GetValue(PositionProperty); }
            set { SetValue(PositionProperty, value); }
        }

        private static void PositionChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var positionObj = obj as InfoEmployee;
            positionObj.position.Text = positionObj.positionEmployee.ToString();
        }

        //Photo
        public static readonly DependencyProperty PhotoProperty = DependencyProperty.Register(
             "photoEmployee",
             typeof(string),
             typeof(InfoEmployee),
             new PropertyMetadata(string.Empty, PhotoChanged));

        public string photoEmployee
        {
            get { return (string)GetValue(PhotoProperty); }
            set { SetValue(PhotoProperty, value); }
        }

        private static void PhotoChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var photoObj = obj as InfoEmployee;
            photoObj.photo.Source = new BitmapImage(new Uri($"pack://application:,,,/{photoObj.photoEmployee}"));
        }

    }
}
