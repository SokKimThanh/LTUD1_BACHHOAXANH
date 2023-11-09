 

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
