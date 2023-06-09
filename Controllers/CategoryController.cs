﻿using Domain.CQRS.Command.Categories;
using Domain.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Domain.Controllers;

public class CategoryController: BaseController
{
    private readonly IMediator _mediator;
    public CategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddCategoryRequest request)
    {
        var result = await _mediator.Send(new AddCategoryCommand(request));
        return Ok(result);
    }
}