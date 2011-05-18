﻿using System;
using System.IO;
using nJupiter.Configuration;
using NUnit.Framework;

namespace nJupiter.UnitTests.Configuration {

	[TestFixture]
	public class FileConfigSourceTests {
		private const string filepath = "c:\\dummyfile.txt";

		[Test]
		public void FileConfigSource_CreateSourceWithFile_ReturnsConfigConfigFileAndUri() {
			var file = new FileInfo(filepath);
			var configSource = (FileConfigSource)ConfigSourceFactory.CreateConfigSource(file);
			
			Assert.AreEqual(file, configSource.ConfigFile);
			Assert.AreEqual(filepath, configSource.ConfigUrl.OriginalString);
		}
		

		[Test]
		public void FileConfigSource_PassingNull_ThrowsArgumentNullException() {
			Assert.Throws<ArgumentNullException>(() => new FileConfigSource(null, null));
		}		

	}
}
