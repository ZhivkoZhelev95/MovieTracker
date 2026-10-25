using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieTracker.Data;
using MovieTracker.Models;


namespace MovieTracker.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies
                .Include(m => m.Genre)
                .Include(m => m.Director)
                .ToListAsync();



            return View(movies);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Genres = new SelectList(
                await _context.Genres.ToListAsync(),
                "Id",
                "Name"
            );

            ViewBag.Directors = new SelectList(
                await _context.Directors.ToListAsync(),
                "Id",
                "Name"
            );

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movie movie)
        {

            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewBag.Genres = new SelectList(
                await _context.Genres.ToListAsync(),
                "Id",
                "Name",
                movie.GenreId
            );

            ViewBag.Directors = new SelectList(
                await _context.Directors.ToListAsync(),
                "Id",
                "Name",
                movie.DirectorId
            );


            return View(movie);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            ViewBag.Genres = new SelectList(
                await _context.Genres.ToListAsync(), "Id", "Name");

            ViewBag.Directors = new SelectList(
                await _context.Directors.ToListAsync(), "Id", "Name");

            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingMovie = await _context.Movies.FindAsync(id);

                if (existingMovie == null)
                {
                    return NotFound();
                }

                existingMovie.Title = movie.Title;
                existingMovie.Description = movie.Description;
                existingMovie.ReleaseYear = movie.ReleaseYear;
                existingMovie.Rating = movie.Rating;
                existingMovie.ImageUrl = movie.ImageUrl;
                existingMovie.IsWatched = movie.IsWatched;
                existingMovie.GenreId = movie.GenreId;
                existingMovie.DirectorId = movie.DirectorId;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Genres = new SelectList(
                await _context.Genres.ToListAsync(), "Id", "Name", movie.GenreId);

            ViewBag.Directors = new SelectList(
                await _context.Directors.ToListAsync(), "Id", "Name", movie.DirectorId);

            return View(movie);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await _context.Movies
                .Include(m => m.Genre)
                .Include(m => m.Director)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}