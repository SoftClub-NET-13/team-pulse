global using Application.Contracts.Repositories;
global using Application.Contracts.Repositories.BaseRepository;
global using Application.Contracts.Repositories.BaseRepository.Crud;
global using Application.Contracts.Services;
global using FluentValidation;
global using Infrastructure.DataAccess;
global using Infrastructure.ImplementationContract.Repositories;
global using Infrastructure.ImplementationContract.Repositories.BaseRepository;
global using Infrastructure.ImplementationContract.Repositories.BaseRepository.Crud;
global using Infrastructure.ImplementationContract.Services;
global using Microsoft.EntityFrameworkCore;
global using FluentValidation.Results;
global using MediatR;
global using Application.Extensions.Responses.ApiResponse;
global using Application.Extensions.ResultPattern;
global using Domain.Enums;
global using Microsoft.AspNetCore.Mvc;
global using Domain.Common;
global using WebAPI.HelpersApi.ApiConventions;
global using Microsoft.AspNetCore.Diagnostics;
global using Application.DTOs;
global using Application.Filters;
global using WebAPI.HelpersApi.Extensions.ResultPattern;