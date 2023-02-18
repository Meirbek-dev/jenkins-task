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
        vsTest(testFiles: '$BUILDPATH\\Userinterface.SpecFlow.dll', useVs2017Plus: true)
      }
    }

    stage('Generate Test Report') {
      steps {
        powershell 'livingdoc test-assembly $BUILDPATH\\Userinterface.SpecFlow.dll -t $BUILDPATH\\TestExecution.json'
      }
    }

    stage('Save Test Report') {
      steps {
        archiveArtifacts 'LivingDoc.html'
      }
    }

  }
  environment {
    BUILDPATH = 'Userinterface.SpecFlow\\bin\\Debug\\net7.0'
  }
}