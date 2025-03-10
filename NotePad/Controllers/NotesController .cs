using Microsoft.AspNetCore.Mvc;
using NotePad.Models;
using System.Diagnostics;

namespace NotePad.Controllers
{
    public class NotesController : Controller
    {
        private static List<Note> notes = new List<Note>(); // Temporary storage

        public IActionResult Index()
        {
            return View(notes);
        }

        [HttpPost]
        public IActionResult AddNote(string title, string content)
        {
            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(content))
            {
                notes.Add(new Note { Id = notes.Count + 1, Title = title, Content = content });
            }
            return RedirectToAction("Index");
        }
    }
}
