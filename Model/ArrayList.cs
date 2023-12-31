﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_MF_BHX
{
    class ArrayList<ThamSoKieu>
    {
        private ThamSoKieu[] items;
        private int size;
        private int capacity;

        public ArrayList(int maxSize)
        {
            capacity = maxSize;
            size = 0;
            items = new ThamSoKieu[capacity];
        }

        /// <summary>
        /// Thuoc tinh property count tra ve so phan tu hien co trong danh sach
        /// </summary>
        public int Count { get => size; }

        /// <summary>
        /// cấp phát bộ nhớ trước khi sử dụng
        /// </summary>
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value >= capacity)
                {
                    capacity = value;
                    Array.Resize(ref items, capacity);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        internal ThamSoKieu[] Data { get => items; set => items = value; }



        /// <summary>
        /// Return value at index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public ThamSoKieu this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                {
                    //chỉ mục không nằm trong khoảng cho phép
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index < 0 || index >= size)
                {
                    //chỉ mục không hợp lệ
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }
        //Kiem tra
        //IsFull(: Kiểm tra mảng đầy
        public bool IsFull()
        {
            return Count == Capacity;
        }
        // isnull
        public bool IsNull()
        {
            if (Count == Capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Hàm Them thêm một phần tử vào cuối mảng Data
        public void AddLast(ThamSoKieu data)
        {

            // Kiểm tra xem kích thước của mảng có đủ lớn để chứa thêm phần tử mới hay không
            if (size >= items.Length)
            {
                // Nếu không đủ, hãy tăng kích thước của mảng
                Array.Resize(ref items, Data.Length * 2);
            }
            // Thêm phần tử mới vào cuối mảng
            items[size] = data;
            size++;
        }

        // Hàm Them thêm một phần tử vào cuối mảng Data
        public bool AddLastBool(ThamSoKieu data)
        {
            bool isThem = false;// chua them duoc
            if (data == null)
            {
                return isThem;
            }
            // Kiểm tra xem kích thước của mảng có đủ lớn để chứa thêm phần tử mới hay không
            if (size >= items.Length)
            {
                // Nếu không đủ, hãy tăng kích thước của mảng
                Array.Resize(ref items, Data.Length * 2);
            }
            // Thêm phần tử mới vào cuối mảng
            items[size] = data;
            size++;
            isThem = true;
            return isThem;
        }


        public void Print()
        {
            if (this.items == null)
            {
                throw new NullReferenceException("Danh sach rong");
            }
            else
            {
                for (int i = 0; i < this.items.Length; i++)
                {
                    Console.WriteLine(this.items[i]!.ToString());
                }
            }

        }

        //Insert(): Thêm một phần tử vào một vị trí trong danh sách
        public void Insert(int index, ThamSoKieu value)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                if (!IsFull())
                {
                    //chép các phần tử từ index về phía sau
                    for (int i = size; i > index; i--)
                    {
                        items[i] = items[i - 1];
                    }
                    //Gán lại gia trị cho phần tử vị trí index
                    items[index] = value;
                    size++;
                }
                else
                {
                    //throw new Exception("Vuot gia tri capacity");
                    throw new IndexOutOfRangeException();
                }
            }
        }

        //Xóa mảng
        //Remove(int value): xóa phần tử có giá trị value đầu tiên xuất hiện trong mảng
        //Tìm vị trí phần tử đầu tiên trong mảng
        public int FindFirstItem(ThamSoKieu value)
        {
            for (int i = 0; i < size; i++)
            {
                if (items[i]!.Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(ThamSoKieu value)
        {
            //Tìm vị trí value xuất hiện đầu tiên
            int pos = FindFirstItem(value);
            if (pos == -1)
            {
                return false;
            }
            //Xóa phần tử tại vị trí pos
            for (int i = pos; i < size - 1; i++)
            {
                items[i] = items[i + 1];
            }

            // Thu gọn mảng: mảng sẽ được thu gọn để giải phóng bộ nhớ không còn sử dụng.
            ThamSoKieu[] newArray = new ThamSoKieu[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
            size--;
            return true;
        }
    }
}
