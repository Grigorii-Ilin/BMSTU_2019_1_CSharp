using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Set {
    public class MySet {
        private List<int> UniqueValues { get; set; }

        public MySet(int[] values) {
            UniqueValues = new List<int>();

            foreach (var value in values) {
                if (!UniqueValues.Contains(value)) {
                    UniqueValues.Add(value);
                }
            }
        }

        public MySet() {
            UniqueValues = new List<int>();
        }

        public int GetCardinality() {
            return UniqueValues.Count;
        }

        public void AddValue(int value) {
            if (!UniqueValues.Contains(value)) {
                UniqueValues.Add(value);
            }
        }

        public void RemoveValue(int value) {
            UniqueValues.Remove(value);
        }

        public static MySet operator + (MySet lhs, MySet rhs) {            
            var result = new MySet();
            result.UniqueValues.AddRange(lhs.UniqueValues);

            foreach (var value in rhs.UniqueValues) {
                if (!result.UniqueValues.Contains(value)) {
                    result.UniqueValues.Add(value);
                }
            }

            return result;
        }

        public static MySet operator -(MySet lhs, MySet rhs) {
            var result = new MySet();
            result.UniqueValues.AddRange(lhs.UniqueValues);

            foreach (var value in rhs.UniqueValues) {
                if (result.UniqueValues.Contains(value)) {
                    result.UniqueValues.Remove(value);
                }
            }

            return result;
        }

        public static MySet operator *(MySet lhs, MySet rhs) {
            var result = new MySet();

            foreach (var lValue in lhs.UniqueValues) {
                foreach (var rValue in rhs.UniqueValues) {
                    if (lValue== rValue) {
                        result.UniqueValues.Add(lValue);
                    }
                }
            }

            return result;
        }

        public static bool operator ==(MySet lhs, MySet rhs) {
            if (lhs.UniqueValues.Count!= rhs.UniqueValues.Count) {
                return false;
            }


            //todo sort lhs, rhs + for 
            foreach (var lValue in lhs.UniqueValues) {
                foreach (var rValue in rhs.UniqueValues) {
                    bool flag = false;
                    if (lValue == rValue) {
                        flag =true;
                        break;
                    }
                    if (!flag) {
                        return false;
                    }
                }
            }

            foreach (var rValue in rhs.UniqueValues) {
                foreach (var lValue in lhs.UniqueValues) {
                    bool flag = false;
                    if (lValue == rValue) {
                        flag = true;
                        break;
                    }
                    if (!flag) {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator !=(MySet lhs, MySet rhs) {
            return !(lhs == rhs);
        }

        public override string ToString() {
            string s="";
            foreach (var value in UniqueValues) {
                s += value.ToString() + " ";
            }

            return s;
        }
    }
}
