using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueConverters.ViewModels.Base;

namespace ValueConverters.ViewModels
{
    public class ExampleViewModel : BindableBase
    {
        public ExampleViewModel()
        {
            isLoading = true;
            displayError = true;
            stringList = new ObservableCollection<string>() { "item1", "item2", "item3" };
            dateTime1 = DateTime.Now.AddDays(-12.0);
            dateTime2 = DateTime.Now.AddDays(-2.0);
            dateTime3 = DateTime.Now.AddHours(-3.0);
            itemList = new ObservableCollection<ListItem>() 
            { 
                new ListItem { Index = 0, Value = "item1" }, 
                new ListItem { Index = 1, Value = "item2" }, 
                new ListItem { Index = 2, Value = "item3" }
            };
            currency = 12.50m;
            myString = "value";
        }

        // For BooleanInvert
        private bool isLoading;

        public bool IsLoading
        {
            get { return this.isLoading; }
            set { this.SetProperty(ref this.isLoading, value); }
        }

        // For BooleanVisibility
        private bool displayError;

        public bool DisplayError
        {
            get { return this.displayError; }
            set { this.SetProperty(ref this.displayError, value); }
        }

        // For CollectionVisibility
        private ObservableCollection<string> stringList;

        public ObservableCollection<string> StringList
        {
            get { return this.stringList; }
            set { this.SetProperty(ref this.stringList, value); }
        }

        // For DateTimeCompact/DateTimeToString
        private DateTime dateTime1;

        public DateTime DateTime1
        {
            get { return this.dateTime1; }
            set { this.SetProperty(ref this.dateTime1, value); }
        }

        private DateTime dateTime2;

        public DateTime DateTime2
        {
            get { return this.dateTime2; }
            set { this.SetProperty(ref this.dateTime2, value); }
        }

        private DateTime dateTime3;

        public DateTime DateTime3
        {
            get { return this.dateTime3; }
            set { this.SetProperty(ref this.dateTime3, value); }
        }

        // For IntegerToAlternatingBrush
        private ObservableCollection<ListItem> itemList;

        public ObservableCollection<ListItem> ItemList
        {
            get { return this.itemList; }
            set { this.SetProperty(ref this.itemList, value); }
        }

        // For ObjectToStringFormat
        private decimal currency;

        public decimal Currency
        {
            get { return this.currency; }
            set { this.SetProperty(ref this.currency, value); }
        }

        // For StringToVisibility
        private string myString;

        public string MyString
        {
            get { return this.myString; }
            set { this.SetProperty(ref this.myString, value); }
        }

    }
}
