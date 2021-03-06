using FluentAssertions;
using HealthNet.Integrations.Runners;
using NUnit.Framework;

namespace HealthNet.Integrations
{
  class When_calling_application_with_a_non_healthcheck_call<TFixtureRunner> : IntegrationFixtures<TFixtureRunner> where TFixtureRunner : IFixtureRunner, new()
  {
    protected override string Path => "/foo";

    [Test]
    public void Should_return_content_from_non_healthcheck_call()
    {
      Response.Content.ReadAsStringAsync().Result.Should().Be("Hello World");
    }
  }
}