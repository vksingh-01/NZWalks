﻿using FluentValidation;

namespace NZWalks.API.Validator
{
    public class AddWalkDifficultyRequestValidator: AbstractValidator<Models.DTO.AddWalkDifficultyRequest>
    {
        public AddWalkDifficultyRequestValidator()
        {
            RuleFor(x => x.Code).NotEmpty();
        }
    }
}
