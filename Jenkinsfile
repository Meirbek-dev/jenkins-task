pipeline {
  agent any
  environment {
    BUILD_PATH = 'Userinterface.SpecFlow\\bin\\Debug\\net7.0'
  }
  stages {
    stage('Build') {
      steps {
        powershell 'dotnet build'
      }
    }

    stage('Test') {
      steps {
        vsTest(testFiles: '${BUILD_PATH}\\Userinterface.SpecFlow.dll', useVs2017Plus: true)
      }
    }

    stage('Generate Test Report') {
      steps {
        powershell 'livingdoc test-assembly ${BUILD_PATH}\\Userinterface.SpecFlow.dll -t ${BUILD_PATH}\\TestExecution.json'
      }
    }

    stage('Save Test Report') {
      steps {
        archiveArtifacts 'LivingDoc.html'
      }
    }

  }
}
