using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using itau_teste.Controllers;
using System.Text.Json;
using System.Text;

namespace integrationTests
{
  public class PasswordTests : IClassFixture<WebApplicationFactory<itau_teste.Startup>>
  {
    private readonly WebApplicationFactory<itau_teste.Startup> _factory;
    private HttpClient _client;

    public PasswordTests(WebApplicationFactory<itau_teste.Startup> factory)
    {
      _factory = factory;
      _client = _factory.CreateClient();
    }

    [Fact]
    public void Must_reject_password_only_repeated_letters()
    {
      validatePassword("aa", 400);
    }

    [Fact]
    public void Must_reject_password_only_letters()
    {
      validatePassword("ab", 400);
    }

    [Fact]
    public void Must_reject_password_upperAndLower_letters_with_upperRepeated()
    {
      validatePassword("AAAbbbCc", 400);
    }

    [Fact]
    public void Must_reject_password_upperAndLowerAndSpecial_with_lowerRepeated()
    {
      validatePassword("AbTp9!foo", 400);
    }

    [Fact]
    public void Must_reject_password_upperAndLowerAndSpecial_with_upperRepeated()
    {
      validatePassword("AbTp9!foA", 400);
    }

    [Fact]
    public void Must_reject_password_upperAndLower_with_space()
    {
      validatePassword("AbTp9 fok", 400);
    }

    [Fact]
    public void Must_approve_password_upperAndLowerAndSpecial_NotRepeated()
    {
      validatePassword("AbTp9!fok", 200);
    }

    [Fact]
    public void Must_reject_password_less_than_nine_caracters()
    {
      validatePassword("AbTp9!fo", 400);
    }

    [Fact]
    public void Must_reject_password_empty()
    {
      validatePassword("", 400);
    }
    [Fact]
    public void Must_reject_password_only_repeated_numbers()
    {
      validatePassword("11", 400);
    }

    [Fact]
    public void Must_reject_password_only_numbers()
    {
      validatePassword("12", 400);
    }

    [Fact]
    public void Must_reject_password_only_Special()
    {
      validatePassword("!@#$%^&*()-+", 400);
    }

    private async void validatePassword(string password, int statusCode)
    {
      var dto = new PasswordDto
      {
        password = password
      };

      var json = JsonSerializer.Serialize(dto);

      var response = await _client.PostAsync("/password/validate",
          new StringContent(json, Encoding.UTF8, "application/json"));

      Assert.Equal(statusCode, (int)response.StatusCode);

    }
  }
}
