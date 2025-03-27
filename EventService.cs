// Services/EventService.cs
using EventRegistrationApp.Models;
using System.Collections.Generic;

namespace EventRegistrationApp.Services
{
    public class EventService
    {
        private readonly List<Event> _events = new List<Event>();

        public IReadOnlyList<Event> GetEvents() => _events;

        public void AddEvent(Event newEvent)
        {
            _events.Add(newEvent);
        }
    }
}