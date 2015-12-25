using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventModels
{
    public class EventService
    {
        public static EventService Instance
        {
            get
            {
                return new EventService();
            }
        }

        public List<SomeEvent> GetNextEvents(DateTime toDate)
        {
            return new List<SomeEvent>()
            {
                new SomeEvent
                {
                    Description = "Cool event ",
                    When = DateTime.Now.AddMinutes(10)
                },
                new SomeEvent
                {
                    Description = "Another one ",
                    When = DateTime.Now.AddMinutes(13)
                },
                new SomeEvent
                {
                    Description = "Good event",
                    When = DateTime.Now.AddMinutes(20)
                },
                new SomeEvent
                {
                    Description = "And one more ",
                    When = DateTime.Now.AddMinutes(33)
                },
            };
        }
    }
}
