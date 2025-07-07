﻿using Core.Business.Utilites.Results;
using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business;
public interface IGenericService<TEntity, TResponseDto,in TCreateDto,in TUpdateDto>
    where TEntity : class, IEntity, new()
    where TResponseDto : class, IResponseDto
    where TCreateDto : class, ICreateDto
    where TUpdateDto : class, IUpdateDto
{
    IResult Insert(TCreateDto dto);
    IResult Modify(TUpdateDto dto);
    IResult Remove(Guid id);

    IDataResult<ICollection<TResponseDto>> GetAll(bool deleted);
    IDataResult<TResponseDto> GetById(Guid id);
}