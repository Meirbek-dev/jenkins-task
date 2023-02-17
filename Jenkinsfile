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

    stage('Generate Test Report') {
      steps {
        sh 'livingdoc test-assembly Userinterface.SpecFlow\\\\bin\\\\Debug\\\\net7.0\\\\Userinterface.SpecFlow.dll -t Userinterface.SpecFlow\\bin\\x86\\Debug\\net7.0\\TestExecution.json'
      }
    }

    stage('Save Test Report') {
      steps {
        archiveArtifacts 'LivingDoc.html'
      }
    }

  }
}