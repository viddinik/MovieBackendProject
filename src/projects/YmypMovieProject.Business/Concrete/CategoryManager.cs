using AutoMapper;
using Core.Business.Utilites.Results;
using Core.Entity;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.Business.Constants;
using YmypMovieProject.Business.Validators;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Categories;
using YmypMovieProject.Entity.Entities;

namespace YmypMovieProject.Business.Concrete
{
    public sealed class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly CategoryValidator _categoryValidator;
        private readonly CategoryUpdateValidator _updateValidator;


        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _categoryValidator = new CategoryValidator();
            _updateValidator = new CategoryUpdateValidator();
        }
        //public IDataResult<ICollection<CategoryResponseDto>> GetAllDeleted()
        //{
        //    try
        //    {
        //        var categories = _categoryRepository.GetAll(c => !c.IsDeleted);
        //        if (categories is null || !categories.Any())
        //        {
        //            return new ErrorDataResult<ICollection<CategoryResponseDto>>(ResultMessages.ErrorCategoryListed);
        //        }
        //        var categoryDtos = _mapper.Map<ICollection<CategoryResponseDto>>(categories);
        //        return new SuccessDataResult<ICollection<CategoryResponseDto>>(categoryDtos, ResultMessages.SuccessCategoryListed);
        //    }
        //    catch (Exception e)
        //    {
        //        return new ErrorDataResult<ICollection<CategoryResponseDto>>($"An error occurred while retrieving categories: {e.Message}");
        //    }
        //}
        public IDataResult<ICollection<CategoryResponseDto>> GetAll(bool deleted)
        {
            try
            {
                var categories = _categoryRepository.GetAll(c => c.IsDeleted == deleted);
                if (categories is null || !categories.Any())
                {
                    return new ErrorDataResult<ICollection<CategoryResponseDto>>(ResultMessages.ErrorCategoryListed);
                }
                var categoryDtos = _mapper.Map<ICollection<CategoryResponseDto>>(categories);
                return new SuccessDataResult<ICollection<CategoryResponseDto>>(categoryDtos,ResultMessages.SuccessCategoryListed); 
            }
            catch (Exception e)
            {
                return new ErrorDataResult<ICollection<CategoryResponseDto>>($"An error occurred while retrieving categories: {e.Message}");
            }

        



            //// tüm kategoriler veritabanından alınır
            //var categories = _categoryRepository.GetQueryableAsync().ToList();
            //// alınan kategoriler mapper ile CategoryResponseDto listesine dönüştürülür.
            //var categoryDtos = _mapper.Map<List<CategoryResponseDto>>(categories);
            //// dönüştürülen liste geri döndürülür.  
            //return categoryDtos;
        }

        public Task<ICollection<CategoryResponseDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryResponseDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task InsertAsync(CategoryAddRequestDto dto)
        {
            try
            {
                //if (dto is null)
                //{
                //    throw new ArgumentNullException(nameof(dto), "CategoryAddRequestDto cannot be null.");
                //}
                ValidationResult result = _categoryValidator.Validate(dto);
                if (!result.IsValid)
                {
                    // Eğer doğrulama başarısızsa, ValidationException fırlatılır.
                    result.Errors.ForEach(error => Console.WriteLine(error.ErrorMessage));
                }
                var category = _mapper.Map<Category>(dto);
                //Category nesnesi veritabanına dataaccess metoduyla eklenir.
                await _categoryRepository.AddAsync(category);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public Task ModifyAsync(CategoryUpdateRequestDto dto)
        {
            throw new NotImplementedException();
        }


        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CategoryResponseDto> GetById(Guid id)
        {
            try
            {
                var category = _categoryRepository.Get(c => c.Id.Equals(id));
                if (category == null)
                {
                    return new ErrorDataResult<CategoryResponseDto>(ResultMessages.ErrorCategoryGetById);
                }
                var dto = _mapper.Map<CategoryResponseDto>(category);
                return new SuccessDataResult<CategoryResponseDto>(dto, ResultMessages.SuccessCategoryGetById);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<CategoryResponseDto>($"getbyid hata !{e.Message}");
            }








            //  id ile category bulunur.
            // var category = _categoryRepository.Get(c => c.Id.Equals(id));
            // Eğer category bulunamazsa, KeyNotFoundException fırlatılır.
            // if (category == null)
            // {
            //    throw new KeyNotFoundException("Category not found");
            // }
            // bulunan category mapper ile CategoryResponseDto nesnesine dönüştürülür.
            // var categoryDto = _mapper.Map<CategoryResponseDto>(category);
            // dönüştürülen nesne geri döndürülür.
            // return categoryDto;
        }


        public IResult Insert(CategoryAddRequestDto dto)
        {
            try
            {   ValidationResult result = _categoryValidator.Validate(dto);
                if (!result.IsValid)
                {
                    string errorMessages = string.Join(",\n", result.Errors.Select(e => e.ErrorMessage));
                    return new ErrorResult(errorMessages);
                }
                var category = _mapper.Map<Category>(dto);
                _categoryRepository.Add(category);
                return new SuccessResult(ResultMessages.SuccessCategoryCreated);
            }
            catch (Exception e)
            {
                return new ErrorResult($"An error occurred while adding the category: {e.Message}");
            }
        }


        public IResult Modify(CategoryUpdateRequestDto dto)
        {
            try
            {
                ValidationResult result = _updateValidator.Validate(dto);
                if (!result.IsValid)
                {
                    string errorMessages = string.Join(",\n", result.Errors.Select(e => e.ErrorMessage));

                    // Hata mesajlarını birleştirir ve ErrorResult döndürür.
                    return new ErrorResult($"{ResultMessages.ErrorCategoryUpdated},\nHata Listesi\n{errorMessages}");
                }
                var category = _mapper.Map<Category>(dto);
                category.UpdateAt = DateTime.Now; // güncelleme tarihi ayarlanır.
                _categoryRepository.Update(category);
                return new SuccessResult(ResultMessages.SuccessCategoryUpdated);

            }
            catch (Exception e)
            {
                return new ErrorResult($"An error occurred while updating the category: {e.Message}");
            }








            //gelen dtoyu mapper ile category nesnesine dönüştürür.
            //Category category = _mapper.Map<Category>(dto);
            //category nesnesinin güncellenme tarihini ayarlar.
            //category.UpdateAt = DateTime.Now;
            //category nesnesi veritabanında güncellenir.
            //_categoryRepository.Update(category);
        }


        public IResult Remove(Guid id)
        {    
            try
            {
                var category = _categoryRepository.Get(c => c.Id.Equals(id));
                if (category == null)
                {
                    return new ErrorResult(ResultMessages.ErrorCategoryGetById);
                }
                category.IsDeleted = true; // Soft delete işlemi
                category.IsActive = false; // Kategoriyi pasif hale getirir
                category.UpdateAt = DateTime.Now; // Güncelleme tarihini ayarlar
                _categoryRepository.Update(category); // Güncellenmiş kategoriyi veritabanına kaydeder
                return new SuccessResult(ResultMessages.SuccessCategoryDeleted);
            }
            catch (Exception e)
            {
                return new ErrorResult($"An error occurred while deleting the category: {e.Message}");
            }
        }

        


        //    public List<Category> GetAll()
        //    {
        //        return _categoryRepository.GetAll();
        //    }

        //    public Category GetById(Guid id)
        //    {
        //        return _categoryRepository.Get(c => c.Id == id);
        //    }

        //    public List<Category> GetByIsActive()
        //    {
        //        return _categoryRepository.GetAll(c => c.IsActive);
        //    }

        //    public List<Category> GetByIsDeleted()
        //    {
        //        return _categoryRepository.GetAll(c => c.IsDeleted);
        //    }

        //    public IQueryable<Category> GetQueryable()
        //    {
        //        return _categoryRepository.GetQueryable();
        //    }

        //    public void Insert(Category entity)
        //    {
        //        _categoryRepository.Add(entity);
        //    }

        //    public void Modify(Category entity)
        //    {
        //        entity.UpdateAt = DateTime.Now;
        //        _categoryRepository.Update(entity);
        //    }

        //    public void Remove(Category entity)
        //    {
        //        entity.IsDeleted = true; // Soft delete logic
        //        entity.IsActive = false; // Optionally set IsActive to false
        //        _categoryRepository.Delete(entity);
        //    }
        //}
    }
}