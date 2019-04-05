using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_scheduler {
    public class ToDoWorking {
        private BindingList<ToDoItem> toDoItems;
        public BindingList<ToDoItem> ToDoItemsForDGV { get; set; }

        public FilterType filterType { get; set; } = FilterType.ShowAll;
        public SortingType sortingType { get; set; } = SortingType.WithoutSorting;

        private const int MAX_FREE_ROWS_COUNT = 10;

        public ToDoWorking() {
            toDoItems = new BindingList<ToDoItem>() {
                new ToDoItem("Купить хлеб", "01.03.2019"),
                new ToDoItem("Съесть пряник", "14.03.2019"),
                new ToDoItem("Поспать побольше"),
            };

            ToDoItemsForDGV = new BindingList<ToDoItem>();
        }

        //private BindingList<ToDoItem> GetItemsForShowAll() {
        //    var result = new BindingList<ToDoItem>();
        //    foreach (var item in toDoItems) {
        //        result.Add(item);
        //    }
        //    return result;
        //}
        private void SetItemsForShowAll() {
            foreach (var item in toDoItems) {
                ToDoItemsForDGV.Add(item);
            }
        }

        //private BindingList<ToDoItem> GetItemsForOnlyUnended() {
        //    var result = new BindingList<ToDoItem>();
        //    foreach (var item in toDoItems) {
        //        if (item.Ended == null) {
        //            result.Add(item);
        //        }
        //    }
        //    return result;
        //}
        private void SetItemsForOnlyUnended() {
            foreach (var item in toDoItems) {
                if (item.Ended == null || item.WorkingName == "") {
                    ToDoItemsForDGV.Add(item);
                }
            }
        }

        private void SetItemsForOnlyEnded() {
            foreach (var item in toDoItems) {
                if (item.Ended != null || item.WorkingName == "") {
                    ToDoItemsForDGV.Add(item);
                }
            }
        }

        private void SetItemsForOnlyWithTime() {
            foreach (var item in toDoItems) {
                if (item.ControlDate != null || item.WorkingName == "") {
                    ToDoItemsForDGV.Add(item);
                }
            }
        }

        private void SetItemsForWithoutTime() {
            foreach (var item in toDoItems) {
                if (item.ControlDate == null || item.WorkingName == "") {
                    ToDoItemsForDGV.Add(item);
                }
            }
        }

        private void SetItemsForBeforeDate(DateTime sortBeforeDate) {
            foreach (var item in toDoItems) {
                if (item.ControlDate <= sortBeforeDate || item.WorkingName == "") {
                    ToDoItemsForDGV.Add(item);
                }
            }
        }

        public void Show(DateTime? sortBeforeDate = null) {
            ToDoItemsForDGV.Clear();

            int freeRows = toDoItems.Where(t => t.WorkingName == "").Count();
            for (int i = 0; i < MAX_FREE_ROWS_COUNT - freeRows; i++) {
                toDoItems.Add(new ToDoItem(""));
            }

            switch (this.filterType) {
            case FilterType.ShowAll:
                //ToDoItemsForDGV = GetItemsForShowAll();
                SetItemsForShowAll();
                //ToDoItemsForDGV = toDoItems;
                break;
            case FilterType.OnlyUnended:
                //foreach (var item in toDoItems) {
                //    if (item.Ended==null) {
                //        ToDoItemsForDGV.Add(item);
                //    }
                //}

                //ToDoItemsForDGV = from t in toDoItems where t.Ended == null;
                SetItemsForOnlyUnended();
                //ToDoItemsForDGV = GetItemsForOnlyUnended();
                break;
            case FilterType.OnlyEnded:
                SetItemsForOnlyEnded();
                break;
            case FilterType.OnlyWithTime:
                SetItemsForOnlyWithTime();
                break;
            case FilterType.WithoutTime:
                SetItemsForWithoutTime();
                break;
            case FilterType.BeforeDate:
                if (sortBeforeDate != null) {
                    SetItemsForBeforeDate((DateTime)sortBeforeDate);
                }
                break;
            default:
                break;
            }



            //ToDoItemsForDGV.Add(new ToDoItem(""));
        }
    }
}
