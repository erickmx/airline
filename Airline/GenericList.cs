using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{

    public delegate bool filterFunc<T, V>(T param1, V param2);
    public delegate int CompareObj<T>(T param1, T param2);

    [Serializable]
    public class GenericList<T> : List<T>
    {

        public GenericList<T> findDatas<V>(V searchValue, filterFunc<V, T> filter)
        {
            GenericList<T> filteredData = new GenericList<T>();

            for (int i = 0; i < this.Count; i++)
            {
                if (filter(searchValue, this[i]))
                {
                    filteredData.Add(this[i]);
                }
            }

            return filteredData;
        }



        public void qSort(CompareObj<T> fun)
        {
            qSort(0, this.Count-1, fun);
        }

        public void qSort(int leftEdge, int rightEdge, CompareObj<T> fun)
        {
            int i = leftEdge;
            int j = rightEdge;
            int medio = (leftEdge + rightEdge) / 2; 
            T pivote = this[medio];

            while (i <= j)
            {
                //while (this[i].compareTo(pivote, opc) == -1) { i++; }
                //while (this[j].compareTo(pivote, opc) == 1) { j--; }

                while (fun(this[i], pivote) == -1) { i++; }
                while (fun(this[j], pivote) == 1) { j--; }

                if (i <= j)
                {
                    exchange(i, j);
                    i++;
                    j--;
                }
            }
            if (leftEdge < j)
            {
                qSort(leftEdge, j, fun);
            }
            if (i < rightEdge)
            {
                qSort(i, rightEdge, fun);
            }
        }

        private void exchange(int a, int b)
        {
            T aux = this[a];
            this[a] = this[b];
            this[b] = aux;
        }


    }
}
