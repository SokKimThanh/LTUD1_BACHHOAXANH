using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_MF_BHX.Model
{
    public interface ISapXepTimKiem
    {
        void InterChangeSort();
        //void SelectionSort();
        void BinarySearch(HangHoa key);
        Node<HangHoa> SequentialSearch(string maHangHoa);
    }
}
