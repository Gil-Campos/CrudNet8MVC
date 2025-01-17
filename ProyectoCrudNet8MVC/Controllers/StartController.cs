using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoCrudNet8MVC.Data;
using ProyectoCrudNet8MVC.Models;

namespace ProyectoCrudNet8MVC.Controllers;

public class StartController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public StartController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View(await _context.Contact.ToListAsync());
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Contact contact)
    {
        if (!ModelState.IsValid) return View();
        
        contact.CreationDate = DateTime.Now;
        _context.Contact.Add(contact);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contact = _context.Contact.Find(id);
        if (contact == null)
        {
            return NotFound();
        }
        
        return View(contact);
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Contact contact)
    {
        if (!ModelState.IsValid) return View();
        
        _context.Update(contact);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    
    [HttpGet]
    public IActionResult Detail(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contact = _context.Contact.Find(id);
        if (contact == null)
        {
            return NotFound();
        }
        
        return View(contact);
    }

    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contact = _context.Contact.Find(id);
        if (contact == null)
        {
            return NotFound();
        }
        
        return View(contact);
    }
    
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteContact(int? id)
    {
        var contact = await _context.Contact.FindAsync(id);
        if (contact == null)
        {
            return View();
        }

        _context.Contact.Remove(contact);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}