﻿using Domain.Users;
using Domain.Users.Events;

using FluentAssertions;

using Unit.Abstractions;

namespace Unit.Users;

public class UserTests : BaseTest
{
    [Fact]
    public void Create_ShouldReturnUser()
    {
        // Act
        var user = User.Create(
            Faker.Internet.Email(),
            Faker.Internet.Password(),
            Faker.Name.FirstName(),
            Faker.Name.LastName());

        // Assert
        user.Should().NotBeNull();
    }

    [Fact]
    public void Create_ShouldReturnUser_WithMemberRole()
    {
        // Act
        var user = User.Create(
            Faker.Internet.Email(),
            Faker.Internet.Password(),
            Faker.Name.FirstName(),
            Faker.Name.LastName());

        // Assert
        user.Roles.Single().Should().Be(Role.Member);
    }

    [Fact]
    public void Create_ShouldRaiseDomainEvent_WhenUserCreated()
    {
        // Act
        var user = User.Create(
            Faker.Internet.Email(),
            Faker.Internet.Password(),
            Faker.Name.FirstName(),
            Faker.Name.LastName());

        // Assert
        UserRegisteredDomainEvent domainEvent =
            AssertDomainEventWasPublished<UserRegisteredDomainEvent>(user);

        domainEvent.UserId.Should().Be(user.Id);
    }

    [Fact]
    public void Update_ShouldRaiseDomainEvent_WhenUserUpdated()
    {
        // Arrange
        var user = User.Create(
            Faker.Internet.Email(),
            Faker.Internet.Password(),
            Faker.Name.FirstName(),
            Faker.Name.LastName());

        // Act
        user.Update(user.LastName, user.FirstName);

        // Assert
        UserProfileUpdatedDomainEvent domainEvent =
            AssertDomainEventWasPublished<UserProfileUpdatedDomainEvent>(user);

        domainEvent.UserId.Should().Be(user.Id);
        domainEvent.FirstName.Should().Be(user.FirstName);
        domainEvent.LastName.Should().Be(user.LastName);
    }

    [Fact]
    public void Update_ShouldNotRaiseDomainEvent_WhenUserNotUpdated()
    {
        // Arrange
        var user = User.Create(
            Faker.Internet.Email(),
            Faker.Internet.Password(),
            Faker.Name.FirstName(),
            Faker.Name.LastName());

        user.ClearDomainEvents();

        // Act
        user.Update(user.FirstName, user.LastName);

        // Assert
        user.DomainEvents.Should().BeEmpty();
    }
}
