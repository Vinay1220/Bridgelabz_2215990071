using System;
using System.IO;
using NUnit.Framework;

public class FileProcessor {
    public void WriteToFile(string filename, string content) {
        File.WriteAllText(filename, content);
    }

    public string ReadFromFile(string filename) {
        if (!File.Exists(filename)) {
            throw new FileNotFoundException("File not found.");
        }
        return File.ReadAllText(filename);
    }
}

[TestFixture]
public class FileProcessorTests {
    private FileProcessor fileProcessor;
    private string testFilePath;

    [SetUp]
    public void Setup() {
        fileProcessor = new FileProcessor();
        testFilePath = "testfile.txt";
    }

    [TearDown]
    public void Teardown() {
        if (File.Exists(testFilePath)) {
            File.Delete(testFilePath);
        }
    }

    [Test]
    public void WriteToFile_CreatesFileAndWritesContent() {
        string content = "Hello, NUnit!";
        fileProcessor.WriteToFile(testFilePath, content);

        Assert.IsTrue(File.Exists(testFilePath));
        Assert.AreEqual(content, File.ReadAllText(testFilePath));
    }

    [Test]
    public void ReadFromFile_ReturnsCorrectContent() {
        string content = "Test content";
        File.WriteAllText(testFilePath, content);

        string result = fileProcessor.ReadFromFile(testFilePath);
        Assert.AreEqual(content, result);
    }

    [Test]
    public void ReadFromFile_NonExistentFile_ThrowsFileNotFoundException() {
        Assert.Throws<FileNotFoundException>(() => fileProcessor.ReadFromFile("nonexistent.txt"));
    }
}
