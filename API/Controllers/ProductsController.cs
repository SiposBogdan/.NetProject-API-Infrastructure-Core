using System;
using API.Requesthelpers;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(IGenericRepository<Product> repo): BaseApiController
{
    // private readonly StoreContext context; 
    // public ProductsController(StoreContext context){
    //     this.context = context;
    // }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<Product>>> GetProducts([FromQuery]ProductSpecParams specParams)
    {
        var spec = new ProductSpecification(specParams);
        
        return await CreatePageResult(repo, spec, specParams.PageIndex, specParams.PageSize); 
    }
    

    [HttpGet("{id:int}")] //apui/products/2
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
       var product =  await repo.GetByIdAsync(id);
       
       if(product == null)
       {
           return NotFound();
       }    

       return product;
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct(Product product)
    {
        repo.Add(product);
        if(await repo.SaveAllAsync())
        {
            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        return BadRequest("Failed to create product");
    }

    [HttpPut ("{id:int}")]
    public async Task<ActionResult<Product>> UpdateProduct(int id, Product product)
    {
        if(id != product.Id || !ProductExists(id))
        {
            return BadRequest("Cannot update this product");
        }
        repo.Update(product);
        if(await repo.SaveAllAsync())
        {
            return NoContent();
        }
        return BadRequest("Failed to update product");

    }

    private bool ProductExists(int id)
    {
        return repo.Exists(id);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Product>> DeleteProduct(int id)
    {
        var product = await repo.GetByIdAsync(id);


        if(product == null)
        {
            return NotFound();
        }
        repo.Remove(product);
        
        if(await repo.SaveAllAsync())
        {
            return NoContent();
        }

        return BadRequest("Failed to delete product");
    }
    [HttpGet("brands")]
    public async Task<ActionResult<IReadOnlyList<string>>> GetBrands()
    {
        //return Ok(await repo.GetBrandsAsync());

        var spec = new BrandListSpecification();
        return Ok(await repo.ListAsync(spec));

    }
    [HttpGet("types")]
    public async Task<ActionResult<IReadOnlyList<string>>> GetTypes()
    {
        //return Ok(await repo.GetTypesAsync());
        var spec = new TypeListSpecification();
        return Ok(await repo.ListAsync(spec));
    }
}
