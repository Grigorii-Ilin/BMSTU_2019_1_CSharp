using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_scheduler {
    public class ToDoWorking {
        private List<ToDoItem> toDoItems;
        ToDoWorking() {
            toDoItems = new List<ToDoItem>() {
                new ToDoItem("1", "Купить хлеб", "01.03.2019", "10.03.2019")
            };
            //var item = new ToDoItem();
            //toDoItems.Add( );
        }
    }
}
