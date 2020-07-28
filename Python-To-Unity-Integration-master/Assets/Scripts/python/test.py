
import PythonBehaviour
import UnityEngine
from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from time import sleep

# Start is called before the first frame update
def Start():
    pass

# Update is called once per frame
def Update():
    pass


path = "/Volumes/SSDexternal/OSX/nicholasnovelle/other/chromedriver"
driver = webdriver.Chrome(path)
driver.get("https://www.facebook.com/")

