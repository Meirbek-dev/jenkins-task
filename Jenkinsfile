pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        powershell 'dotnet build'
      }
    }

    stage('Test') {
      steps {
        vsTest(testFiles: 'Userinterface.SpecFlow\\bin\\Debug\\net7.0\\Userinterface.SpecFlow.dll', useVs2017Plus: true)
      }
    }

    stage('Save Log') {
      steps {
        archiveArtifacts 'Userinterface.SpecFlow\\Log\\log.log'
      }
    }

  }
}