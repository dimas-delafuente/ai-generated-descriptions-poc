using System.Text;
using AIDescriptions.Web.Models;

namespace AIDescriptions.Web.Services;

public class PromptBuilder
{
    private readonly StringBuilder _builder;

    public PromptBuilder(bool isHtml = false)
    {
        _builder = new(
            "You are a marketing expert for e-commerce sellers, who is specialized in writing product descriptions." +
            "Sellers will ask you to write product descriptions and you will generate one for them, just replying directly with the description you built," +
            "without including additional comments about what you have generated for them, as they will use whatever you generate." +
            "The description must be attractive to customers while making sure it fits a marketplace ad." +
            "DO NOT INCLUDE IMAGES!." + 
            "Wrap the description text within a block that starts with [DESCRIPTION] and ends with [/DESCRIPTION].");

        _builder.AppendLine();

		if (isHtml)
		{
			_builder.AppendLine("Format the description output as valid HTML block that can be used in a website.");
		}
		
        _builder.AppendLine();
    }

    public PromptBuilder Start(int length)
    {
        _builder.AppendLine($"Write a description of my product to sell it in an e-commerce marketplace.");
        _builder.AppendLine($"The product description must have a reference to the list of details below and a maximum length of {length} characters.");

        return this;
    }

    public PromptBuilder WithCoreDetails(Dictionary<string, string> coreAttributes)
    {
        foreach (var attribute in coreAttributes)
        {
            AppendAttribute(attribute.Key, attribute.Value);
        }

        return this;
    }

    public PromptBuilder WithAdditionalDetails(Dictionary<string, string> additionalDetails)
    {
        foreach (var attribute in additionalDetails)
        {
            AppendAttribute(attribute.Key, attribute.Value);
        }

        return this;
    }

    public string ToPrompt()
    {
        var prompt = _builder.ToString();
        _builder.Clear();

        return prompt;
    }

    public static string FromItem(InventoryItem item, int length, bool asHtml = false)
    {
        var prompt = new PromptBuilder(asHtml)
            .Start(length)
            .WithCoreDetails(item.CoreAttributes)
            .WithAdditionalDetails(item.AdditionalAttributes)
            .ToPrompt();

        return prompt;
    }

    private void AppendAttribute(string name, string value)
    {
        _builder.AppendLine($"{name}: {value}");
    }
}
