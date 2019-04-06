using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_scheduler {
    public class ToDoWorking {
        private BindingList<ToDoItem> toDoItems;
        public BindingList<ToDoItem> ToDoItemsForDGV { get; set; }

        public FilterType filterType { get; set; } = FilterType.ShowAll;
        public SortingType sortingType { get; set; } = SortingType.WithoutSorting;

        //private const int MAX_FREE_ROWS_COUNT = 10;
        private const string TABLE_FILE_NAME = "table.csv";

        public ToDoWorking() {
            toDoItems = new BindingList<ToDoItem>(); //{
            //    new ToDoItem("Купить хлеб", "01.03.2019"),
            //    new ToDoItem("Съесть пряник", "14.03.2019"),
            //    new ToDoItem("Поспать побольше"),
            //};

            ToDoItemsForDGV = new BindingList<ToDoItem>();
        }

        private void SetItemsForShowAll(){//(BindingList<ToDoItem> sortedList) {

            foreach (var item in toDoItems) {
                ToDoItemsForDGV.Add(item);
            }
        }

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
            const int MAX_FREE_ROWS_COUNT = 10;
            for (int i = 0; i < MAX_FREE_ROWS_COUNT - freeRows; i++) {
                toDoItems.Add(new ToDoItem(""));
            }

            switch (this.sortingType) {
                //todo better
                case SortingType.AlphabetSorting:
                    var tmp1 = new BindingList<ToDoItem>(toDoItems
                                            .OrderByDescending(x => x.WorkingName)
                                            .ToList());
                    toDoItems = tmp1;
                    break;
                case SortingType.ControlDateSorting:
                    var tmp2 = new BindingList<ToDoItem>(toDoItems
                            .OrderByDescending(x => x.ControlDate)
                            .ToList());
                    toDoItems = tmp2;
                    break;
                default:
                    break;
            }


            switch (this.filterType) {
            case FilterType.ShowAll:
                SetItemsForShowAll();
                break;
            case FilterType.OnlyUnended:
                SetItemsForOnlyUnended();
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
        }

        public void Load() {
            if (File.Exists(TABLE_FILE_NAME)) {
                using (var reader = new StreamReader(TABLE_FILE_NAME)) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        //for Strart, ControlDate and Ended
                        DateTime?[] loadedDT = new DateTime?[]{ null,null, null};
                        for (int i = 0; i < loadedDT.Length; i++) {
                            DateTime tmp;
                            if (DateTime.TryParse(values[i+2], out tmp)) {
                                loadedDT[i] =  tmp;
                            }
                        }

                        var toDoItem = new ToDoItem() {
                            Id = new Guid(values[0]),
                            WorkingName= values[1],
                            Strart= (DateTime)loadedDT[0],
                            ControlDate = loadedDT[1],
                            Ended = loadedDT[2],
                        };

                        toDoItems.Add(toDoItem);
                    }
                }
            }
        }

        public void Save() {
            using (var writer = new StreamWriter(TABLE_FILE_NAME)) {
                foreach (var item in toDoItems) {
                    var line = string.Format("{0},{1},{2},{3},{4}",
                                            item.Id.ToString(),
                                            item.WorkingName.ToString(),
                                            item.Strart.ToString(),
                                            item.ControlDate.ToString(),
                                            item.Ended.ToString()
                                            );
                    writer.WriteLine(line);
                    writer.Flush();
                }
            }
        }
    }
}
