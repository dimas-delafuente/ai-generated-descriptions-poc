using AIDescriptions.Web.Models;

namespace AIDescriptions.Web.Samples;

public static class InventoryItemSamples
{
    public static InventoryItem DrawerOrganizer = new()
    {
        SKU = "SKU1",
        CoreAttributes = new Dictionary<string, string> 
        {
            ["Title"] = "Aldo Drawer Organizer",
            ["Brand"] = "mDesign",
            ["Manufacturer"] = "MetroDecor",
            ["Color"] = "gray",
            ["Height (inches)"] = "12",
            ["Length (inches)"] = "12",
            ["Width (inches)"] = "12",
        },
        AdditionalAttributes = new Dictionary<string, string>
        {
            ["Amazon Category"] = "Home and Garden",
            ["Amazon Title"] = "mDesign Rectangular Soft Fabric Dresser Drawer and Closet Storage Organizer for Lingerie, Bras, Socks, Leggings, Clothes, Jewelry, Scarves - Light Gray",
            ["Bullet point 1"] = "ORGANIZING MADE EASY: Perfect for storing and organizing tights, belts, underwear, sports bras, clutch and wristlet purses and more. Open top allows for easy access to your essential items, extras and accessories.",
            ["Bullet point 2"] = "STYLISH STORAGE: The soft storage organizer keeps closet clutter under control by storing clothing, jewelry and accessories in one place. Also perfect for use on dresser and vanity tops for storing makeup, cosmetics, brushes, hair needs and more.",
            ["Bullet point 3"] = "VERSATILE: Create coordinated organization in drawers, shelves, closets, cabinets and dressers. Great for adults and children. Use in office, nursery or bathroom drawers for organization in any space.",
            ["Bullet point 4"] = "DURABLE CONSTRUCTION: Made of breathable polypropylene fabric with a textured pattern and coordinating solid color trim. Reinforced sides keep items secure and the bins keep their shape. Wipe clean with a damp cloth and allow to air dry.",
        }
    };
    
    public static InventoryItem NailPolish = new()
    {
        SKU = "SKU2",
        CoreAttributes = new Dictionary<string, string> 
        {
			["Brand"] = "Sinful Colors",
			["Title"] = "Sinful Colors Professional Nail Polish, Rise and Shine 940, 0.5 fl oz",
            ["Color"] = "Red",
        },
        AdditionalAttributes = new Dictionary<string, string>
        {
            ["Amazon Category"] = "Beauty",
            ["Bullet point 1"] = "Toluene, formaldehyde & DBP free",
            ["Bullet point 2"] = "Made in USA",
            ["Bullet point 3"] = "Size: 0.5 fl oz",
            ["Bullet point 4"] = "Color: Rise and Shine."
        }
	};

    public static InventoryItem KirbyBox = new()
    {
        SKU = "SKU2",
        CoreAttributes = new Dictionary<string, string>
        {
            ["Brand"] = "Kirby",
            ["Title"] = "Re-ment Kirby Terrarium DX Memories Random Blind (Box Set of 6)",
            ["Color"] = "Red",
            ["Description"] = "Kirby is a Japanese action-platformer video game series developed by HAL Laboratory and published by Nintendo. The series centers around the adventures of a young, pink alien hero named Kirby as he fights to save his home on the distant Planet Popstar from a variety of threats."
        },
        AdditionalAttributes = new Dictionary<string, string>
        {
            ["Category Tree (Amz):"] = "Toys & Games>Toy Figures & Playsets",
            ["BulletPoints"] = "Bullet Points: Official Product By Re-ment | Cute and Collectible | Makes a great gift | You will receive a sealed box set of 6 random blind box figures | Character List: Green Greens, Float Island, The Great Cave Offensive, Final War, Nova, Warp Star",
        }
    };
}
