using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogQueue.Model
{
    public class DuplexLinkedDeque<T>
    {
        private DuplexItem<T> head;
        private DuplexItem<T> tail; 
        public int Count { get; set; }
        public DuplexLinkedDeque() { }

        public DuplexLinkedDeque(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            var item = new DuplexItem<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }

        public void PushBack(T data)
        {
            if(Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            item.Next = tail;
            tail.Previous = item;
            tail = item;
            Count++;
        }

        public void PushFront(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            item.Previous = head;
            tail.Next = item;
            head = item;
            Count++;
        }

        public T PopBack()
        {
            if(Count > 0)
            {
                var result = tail.Data;
                var current = tail.Next;
                current.Previous = null;
                Count--;
                return result;
            }
            else
            {
                return default(T);
            }
        }

        public T PopFront()
        {
            if (Count > 0)
            {
                var result = head.Data;
                var current = head.Previous;
                current.Next = null;
                Count--;
                return result;
            }
            else
            {
                return default(T);
            }
        }

        public T PeekBack()
        {
            return tail.Data;
        }

        public T PeekFront()
        {
            return head.Data;
        }
    }
}
