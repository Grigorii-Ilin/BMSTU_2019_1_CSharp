using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_scheduler {
    public class ToDoWorking {
        private BindingList<ToDoItem> toDoItems;
        public FilterType filterType { get; set; } = FilterType.ShowAll;
        public SortingType sortingType { get; set; } = SortingType.WithoutSorting;

        public ToDoWorking() {
            toDoItems = new BindingList<ToDoItem>() {
                new ToDoItem("Купить хлеб", "01.03.2019"),
                new ToDoItem("Съесть пряник", "14.03.2019")
            };
        }

        public BindingList<ToDoItem> Show() {
            return toDoItems;
        }
    }
}
