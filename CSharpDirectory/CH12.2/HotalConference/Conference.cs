using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public enum Room
    {
        ROOM_101,
        ROOM_102,
        ROOM_201,
        ROOM_202,
        ROOM_301,
        ROOM_302
    }
    class Conference
    {
        private string _groupName;
        private string _startDate;
        private int _attendees;
        private string _roomNumber;

        public Conference(string groupName, string startDate, int attendees, string roomNumber)
        {
            _groupName = groupName;
            _startDate = startDate;
            _attendees = attendees;
            _roomNumber = roomNumber;
        }


               public string GroupName
        {
            set {  _groupName = value; }
            get { return _groupName; }
        }
        //Property
        public string StartDate
        {
            set { _startDate = value; }
            get { return _startDate; }
        }
        //Property
        public int Attendees
        {
            set { _attendees = value; }
            get { return _attendees; }

        }
        public string RoomNumber
        {
            set { _roomNumber = value; }
            get { return _roomNumber; }
        }

       

        public string Display() => $" |Client: {_groupName}| Project Date: {_startDate}| Location: {_roomNumber}| Price: ${_attendees}|  \n";
    }
}



