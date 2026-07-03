// Events
class Teacher
{
    SortedList<int, ExamDelegate> _sortedEvents = new();
    Random _random = new Random();
    public event ExamDelegate ExamEvent
    {
        add {
            for (int key = 0; ;)
            {
                key = _random.Next();
                if (!_sortedEvents.ContainsKey(key))
                {
                    _sortedEvents.Add(key, value);
                    break;
                }
            }
        }
        remove {
            _sortedEvents.Remove(_sortedEvents.IndexOfValue(value));
        }
    }

    public void Exam(string task)
    {
        foreach (var key in _sortedEvents.Keys)
        {
            if (_sortedEvents[key] is not null)
                _sortedEvents[key](task);
        }
    }

}

