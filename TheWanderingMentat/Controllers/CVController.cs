using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using TheWanderingMentat.Models;

namespace TheWanderingMentat.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index() {
            // Create a new LabelGridMover instance and populate it with image data
            LabelGridMover mover = new LabelGridMover();
            mover.AllSquares = new List<FloatingSquare>{
                    new FloatingSquare { Id = "red", Src = "~/red.png", Alt = "R", X = 0, Y = 0 },
                    new FloatingSquare { Id = "blue", Src = "~/blue.png", Alt = "B", X = 0, Y = 0 }
                };

            mover.RecalculatePos();
            mover.MoveImages();

            // Return the view with the updated image positions
            return View(mover);
        }
        public IActionResult Move(string squareId) {
            return Content($"<script>moveSquare('{squareId}');</script>", "text/html");
            //return JavaScript("moveSquare('" + squareId + "');");
        }
    }
}
