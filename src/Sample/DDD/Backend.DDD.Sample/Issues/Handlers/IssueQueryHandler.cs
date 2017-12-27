﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.DDD.Sample.Contracts.Issues.Queries;
using GoldenEye.Backend.Core.DDD.Queries;
using GoldenEye.Backend.Core.Repositories;
using Marten;
using IssueViews = Backend.DDD.Sample.Contracts.Issues.Views;

namespace Backend.DDD.Sample.Issues.Handlers
{
    internal class IssueQueryHandler :
        IAsyncQueryHandler<GetIssues, IReadOnlyList<IssueViews.Issue>>,
        IAsyncQueryHandler<GetIssue, IssueViews.Issue>
    {
        private readonly IReadonlyRepository<IssueViews.Issue> repository;

        public IssueQueryHandler(IReadonlyRepository<IssueViews.Issue> repository)
        {
            this.repository = repository ?? throw new ArgumentException(nameof(repository));
        }

        public Task<IReadOnlyList<IssueViews.Issue>> Handle(GetIssues message)
        {
            return repository
                .GetAll()
                .ToListAsync();
        }

        public Task<IssueViews.Issue> Handle(GetIssue message)
        {
            return repository.GetByIdAsync(message.Id);
        }
    }
}