﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Data;
using WebPage8.Models;
using WebPage8.ViewModels;

namespace WebPage8.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IComputerRepo _computerRepo;
        public CategoryService(ICategoryRepo categoryRepo, IComputerRepo computerRepo)
        {
            _categoryRepo = categoryRepo;
            _computerRepo = computerRepo;
        }
        public Category Add(CreateCategoryViewModel person)
        {
            throw new NotImplementedException();
        }

        public CategoryViewModel All()
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel
            {
                Categories = _categoryRepo.Read()
            };
            return categoryViewModel;
        }

        public Category Edit(int id, Category person)
        {
            throw new NotImplementedException();
        }

        public CategoryViewModel FindBy(CategoryViewModel search)
        {
            search.Categories = _categoryRepo.Read()
                .FindAll(category =>
                    category.Name.Contains(search.Search, System.StringComparison.OrdinalIgnoreCase));
            return search;
        }

        public ComputerViewModel FindByBrand(CategoryViewModel search)
        {
            ComputerViewModel computerViewModel = new ComputerViewModel
            {
                Computers = _computerRepo.Read()
                    .FindAll(computer =>
                    computer.Category.Name.Contains(search.Search, System.StringComparison.OrdinalIgnoreCase))
                };            
            return computerViewModel;
        }

        public Category FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
