using Microsoft.AspNetCore.Mvc;
using PaperUniasselvi.Data;
using PaperUniasselvi.Models;

namespace PaperUniasselvi.Controllers;

public class PatrocinadorController : Controller
{

    private readonly ApplicationDbContext _db;

    public PatrocinadorController( ApplicationDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult Index()
    {
        IEnumerable<CadastroDeEntidades> entidades = _db.Entidades;
        return View( entidades );
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Cadastrar(CadastroDeEntidades entidades)
    {

        if (ModelState.IsValid)
        {
            _db.Entidades.Add(entidades);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        return View( entidades );
    }

    [HttpGet]
    public IActionResult Editar( int? id )
    {
        if ( id.Equals( null ) || id.Equals( 0 ) )
        {
            return NotFound();
        }

        CadastroDeEntidades entidades = _db.Entidades.FirstOrDefault( x => x.id == id );

        if ( entidades.Equals( null ) )
        {
            return NotFound();
        }

        return View( entidades );
    }

    [HttpPost]
    public IActionResult Editar(CadastroDeEntidades entidades)
    {

        if(ModelState.IsValid)
        {

            _db.Entidades.Update(entidades);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        return View();

    }

    [HttpGet]
    public IActionResult Delete( int? id )
    {

        if ( id.Equals( null ) || id.Equals( 0 ) )
        {
            return NotFound();
        }

        CadastroDeEntidades entidades = _db.Entidades.FirstOrDefault( x => x.id == id );

        if ( entidades.Equals( null ) )
        {
            return NotFound();
        }

        return View( entidades );
    }

    [HttpPost]
    public IActionResult Delete( CadastroDeEntidades entidades )
    {

        if ( entidades.Equals( null ) )
        {
            return NotFound();
        }

        _db.Entidades.Remove( entidades );
        _db.SaveChanges();

        return RedirectToAction( "Index" );

    }
}